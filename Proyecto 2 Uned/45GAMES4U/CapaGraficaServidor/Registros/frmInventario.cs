using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaEntidades;
using CapaLogica;
/*
 UNED I Cuatrimestre
 Proyecto 2: Se ha solicitado el desarrollo de una aplicación cliente-servidor de escritorio en C# 
 para la cadena de tiendas de videojuegos 45GAMES4U, con el objetivo de gestionar 
 y administrar el inventario de videojuegos en cada una de sus tiendas desde el servidor. Por el lado 
  del cliente se busca la gestión de reservas de videojuegos físicos en tiendas asociadas, esta permite a los clientes:
validarse mediante su identificación, visualizar las tiendas disponibles, consultar el inventario de videojuegos por tienda,
realizar reservas y visualizar sus reservas.

 * 
 * Estudiante: Daniel Tapia Traña
 * 
 * Fecha: 06/04/25
 */


/*
 Referencias del codigo:
RJ Code Advance. (2018, 19 abril). CRUD con C#, WinForm, SQL Server, POO y Arquitectura en Capas- Nivel Básico
[Vídeo]. YouTube. https://www.youtube.com/watch?v=_H8vswpMSOw
 */
namespace CapaGraficaServidor.Registros
{
    public partial class frmInventario : Form
    {
        private readonly LogicaTienda logicaTienda;
        private readonly LogicaVideojuego logicaVideojuego;
        private readonly LogicaVideojuegosXTienda logicaInventario;

        public frmInventario()
        {
            InitializeComponent();
            logicaTienda = new LogicaTienda();
            logicaVideojuego = new LogicaVideojuego();
            logicaInventario = new LogicaVideojuegosXTienda();
            CargarCombos();
            CargarVideojuegosFisicos();
        }
        // Método para cargartiendas registradas en el cmb
        private void CargarCombos()
        {
            cmbTienda.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTienda.Items.Clear();

            var tiendas = logicaTienda.ObtenerTodos(out string mensaje);

            if (!string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, "Error al cargar tiendas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var t in tiendas)
            {
                if (t.Activa)
                    cmbTienda.Items.Add(t);
            }
        }
        // Método cargar videojuegos fisicos en el dgv
        private void CargarVideojuegosFisicos()
        {
            dgvVideojuegos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVideojuegos.MultiSelect = true;
            dgvVideojuegos.ReadOnly = true;
            dgvVideojuegos.AllowUserToAddRows = false;

            var fisicos = logicaVideojuego.ObtenerVideojuegosFisicos(out string mensaje);

            if (!string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, "Error al cargar videojuegos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (fisicos.Count == 0)
            {
                MessageBox.Show("No hay videojuegos físicos registrados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvVideojuegos.DataSource = null;
            dgvVideojuegos.DataSource = fisicos;

            dgvVideojuegos.Columns[0].HeaderText = "ID";
            dgvVideojuegos.Columns[1].HeaderText = "Nombre";
            dgvVideojuegos.Columns[2].HeaderText = "Tipo";
            dgvVideojuegos.Columns[3].HeaderText = "Desarrollador";
            dgvVideojuegos.Columns[4].HeaderText = "Lanzamiento";
            dgvVideojuegos.Columns[5].HeaderText = "Físico";
        }

        // Validación de entradas antes de crear la entidad
        private bool ValidarEntradas(out int cantidad)
        {
            cantidad = 0;

            if (cmbTienda.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una tienda activa.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtExistencias.Text) || !int.TryParse(txtExistencias.Text, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Las existencias deben ser un número mayor a 0.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dgvVideojuegos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un videojuego.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        // Método para limpiar los campos del formulario
        private void Limpiar()
        {
            cmbTienda.SelectedIndex = -1;
            txtExistencias.Clear();
            dgvVideojuegos.ClearSelection();
        }
        // Evento: volver al menú de registros 
        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            frmRegistros frmRe = new frmRegistros();
            frmRe.Show();
        }
        // Evento: guardar los videojuegos por tienda
        private void btnGuardarVideojuego_Click(object sender, EventArgs e)
        {
            if (!ValidarEntradas(out int cantidad))
                return;

            var tienda = (TiendaEntidad)cmbTienda.SelectedItem;
            int registrosExitosos = 0;
            int registrosDuplicados = 0;

            foreach (DataGridViewRow fila in dgvVideojuegos.SelectedRows)
            {
                var videojuego = (VideojuegoEntidad)fila.DataBoundItem;

                var asociacion = new VideojuegosXTiendaEntidad
                {
                    Tienda = tienda,
                    Videojuego = videojuego,
                    Existencias = cantidad
                };

                bool resultado = logicaInventario.Insertar(asociacion, out string mensaje);

                if (!resultado)
                {
                    if (mensaje.Contains("ya está asignado"))
                        registrosDuplicados++;
                    else
                        MessageBox.Show($"Error con '{videojuego.Nombre}': {mensaje}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    continue;
                }

                registrosExitosos++;
            }

            if (registrosExitosos == 0 && registrosDuplicados > 0)
            {
                MessageBox.Show("Todos los videojuegos seleccionados ya están asignados a esta tienda.", "Duplicados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (registrosExitosos > 0)
            {
                string resumen = $"{registrosExitosos} videojuego(s) asociado(s) correctamente.";
                if (registrosDuplicados > 0)
                    resumen += $"\n{registrosDuplicados} ya estaban registrados y no fueron duplicados.";

                MessageBox.Show(resumen, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
        }
    }
}
