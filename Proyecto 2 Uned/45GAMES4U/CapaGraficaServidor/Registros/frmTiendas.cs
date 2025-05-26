using System;
using System.Windows.Forms;
using CapaLogica;
using CapaEntidades;
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
    public partial class frmTiendas : Form
    {
        private readonly LogicaTienda logicaTienda;
        private readonly LogicaAdministrador logicaAdministrador;
        public frmTiendas()
        {
            InitializeComponent();
            logicaTienda = new LogicaTienda();
            logicaAdministrador = new LogicaAdministrador();
            CargarCombos();
        }

        // Método para obtener los datos del formulario y convertirlos en una entidad
        private TiendaEntidad ObtenerDatosFormulario()
        {
            if (!ValidarEntradas())
                return null;

            try
            {
                return new TiendaEntidad
                {
                    Nombre = txtNombreTienda.Text.Trim(),
                    Direccion = txtDireccion.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Activa = cmbActiva.SelectedItem.ToString() == "Sí",
                    Administrador = (AdministradorEntidad)cmbAdministrador.SelectedItem
                };
            }
            catch (Exception ex)
            {
                MostrarError($"Error al obtener datos: {ex.Message}");
                return null;
            }
        }
        // Validación de entradas antes de crear la entidad
        private bool ValidarEntradas()
        {
            if (string.IsNullOrWhiteSpace(txtNombreTienda.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MostrarAdvertencia("Todos los campos son requeridos.");
                return false;
            }

            if (cmbAdministrador.SelectedItem == null)
            {
                MostrarAdvertencia("Debe seleccionar un administrador.");
                return false;
            }

            return true;
        }
        // Método para limpiar los campos del formulario
        private void LimpiarFormulario()
        {
            txtNombreTienda.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            cmbAdministrador.SelectedIndex = 0;
            cmbActiva.SelectedIndex = 0;
            txtNombreTienda.Focus();
        }

        // Métodos para cargar los administradores para que puedan ser elegidos en el cmb
        private void CargarCombos()
        {
            cmbActiva.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAdministrador.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAdministrador.Items.Clear();

            var lista = logicaAdministrador.ObtenerTodos(out string mensaje);

            if (!string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, "Error al cargar administradores", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var admin in lista)
            {
                cmbAdministrador.Items.Add(admin); // Gracias al ToString() se verá el nombre completo
            }
        }
        // Evento: guardar los datos de la tienda
        private void btnGuardarTiendas_Click(object sender, EventArgs e)
        {
            var tienda = ObtenerDatosFormulario();
            if (tienda == null) return;

            if (logicaTienda.Insertar(tienda, out string mensaje))
            {
                MostrarExito(mensaje);
                LimpiarFormulario();
            }
            else
            {
                MostrarError(mensaje);
            }

        }
        // Métodos para mostrar una mensajes al usuario

        private void MostrarExito(string mensaje)
        {
            MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MostrarAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void MostrarError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
