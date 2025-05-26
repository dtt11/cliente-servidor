using System;
using System.Collections;
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
namespace CapaGraficaServidor
{
    public partial class frmVideojuegos : Form
    {
        private readonly LogicaVideojuego logicaVideojuego;
        private readonly LogicaTipoVideojuego logicaTipoVideojuego;

        public frmVideojuegos()
        {
            InitializeComponent();
            logicaVideojuego = new LogicaVideojuego();
            logicaTipoVideojuego = new LogicaTipoVideojuego();
            CargarCombos();
        }
        // Método para obtener los datos del formulario y convertirlos en una entidad
        private VideojuegoEntidad ObtenerDatosFormulario()
        {
            if (!ValidarEntradas())
                return null;

            try
            {
                return new VideojuegoEntidad
                {
                    Nombre = txtNombreVideojuego.Text.Trim(),
                    Desarrollador = txtDesarrolladora.Text.Trim(),
                    Lanzamiento = int.Parse(txtAnoLanzamiento.Text.Trim()),
                    TipoVideojuego = (TipoVideojuegoEntidad)cmbTipoVideojuego.SelectedItem,
                    Fisico = cmbFisicoVirtual.SelectedItem.ToString() == "Físico"
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        // Metodo para cargar todos lot tipos de videojuegos en los cmb
        private void CargarCombos()
        {
            cmbFisicoVirtual.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoVideojuego.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoVideojuego.Items.Clear();

            var resultado = logicaTipoVideojuego.ObtenerTodos(out string mensaje);

            if (!string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var tipo in resultado)
            {
                cmbTipoVideojuego.Items.Add(tipo); // Gracias al ToString() se verá el nombre 
            }
           
        }
        // Validación de entradas antes de crear la entidad
        private bool ValidarEntradas()
        {
            if (
                string.IsNullOrWhiteSpace(txtNombreVideojuego.Text) ||
                cmbTipoVideojuego.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtDesarrolladora.Text) ||
                string.IsNullOrWhiteSpace(txtAnoLanzamiento.Text) ||
                !int.TryParse(txtAnoLanzamiento.Text, out _) ||
                cmbFisicoVirtual.SelectedIndex == -1
            )
            {
                MessageBox.Show("FORMULARIO INCOMPLETO, Digite todos los datos requeridos para completar el formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        // Método para limpiar los campos del formulario
        private void LimpiarEntradas()
        {
            txtNombreVideojuego.Text = "";
            txtDesarrolladora.Text = "";
            txtAnoLanzamiento.Text = "";
            cmbTipoVideojuego.SelectedIndex = -1;
            cmbFisicoVirtual.SelectedIndex = -1;
        }
        // Evento: guardar los datos del videojuego
        private void btnGuardarVideojuego_Click(object sender, EventArgs e)
        {
            var videojuego = ObtenerDatosFormulario();
            if (videojuego == null) return;

            bool resultado = logicaVideojuego.Insertar(videojuego, out string mensaje);
            MessageBox.Show(mensaje, resultado ? "Éxito" : "Error", MessageBoxButtons.OK, resultado ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (resultado)
                LimpiarEntradas();
        }
        // Evento: volver al menú de registros 
        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            frmRegistros frmRe = new frmRegistros();
            frmRe.Show();
        }
    }
}
