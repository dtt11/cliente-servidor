using System;
using System.Security.Cryptography;
using System.Windows.Forms;
using CapaEntidades;
using CapaLogica;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
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
    public partial class frmClientes : Form
    {
        private readonly LogicaCliente logicaCliente;

        public frmClientes()
        {
            InitializeComponent();
            logicaCliente = new LogicaCliente();
            cmbJugadorEnLinea.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        // Método para obtener los datos del formulario y convertirlos en una entidad
        private ClienteEntidad ObtenerDatosFormulario()
        {
            if (!ValidarEntradas())
                return null;

            try
            {
                return new ClienteEntidad
                {
                    Id = int.Parse(txtIdCliente.Text.Trim()),
                    Nombre = txtNombreCLiente.Text.Trim(),
                    PrimerApellido = txtPrimerApellidoCliente.Text.Trim(),
                    SegundoApellido = txtSegundoApellidoCliente.Text.Trim(),
                    FechaNacimiento = dtpFechaNacimiento.Value.Date,
                    JugadorEnLinea = cmbJugadorEnLinea.SelectedItem.ToString() == "Sí"
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos del formulario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


  /*      Método ValidarEntradas()
Este método revisa que todos los campos obligatorios del formulario hayan sido completados.*/
        private bool ValidarEntradas()
        {
            if (string.IsNullOrWhiteSpace(txtIdCliente.Text) ||
                string.IsNullOrWhiteSpace(txtNombreCLiente.Text) ||
                string.IsNullOrWhiteSpace(txtPrimerApellidoCliente.Text) ||
                string.IsNullOrWhiteSpace(txtSegundoApellidoCliente.Text) ||
                cmbJugadorEnLinea.SelectedIndex == -1)
            {
                MessageBox.Show("Debe completar todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtIdCliente.Text.Trim(), out _))
            {
                MessageBox.Show("La identificación debe ser un número entero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        /*
Método LimpiarFormulario()
Este método limpia todos los campos del formulario, dejándolos en su estado inicial.

         */
        private void LimpiarFormulario()
        {
            txtIdCliente.Clear();
            txtNombreCLiente.Clear();
            txtPrimerApellidoCliente.Clear();
            txtSegundoApellidoCliente.Clear();
            cmbJugadorEnLinea.SelectedIndex = -1;
            dtpFechaNacimiento.Value = DateTime.Today;
        }

        //btn para guardar el cliente
        private void btnGuardarCliente_Click_1(object sender, EventArgs e)
        {
            var cliente = ObtenerDatosFormulario();
            if (cliente == null) return;

            bool resultado = logicaCliente.Insertar(cliente, out string mensaje);

            MessageBox.Show(mensaje, resultado ? "Éxito" : "Error", MessageBoxButtons.OK,
                resultado ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (resultado)
                LimpiarFormulario();
        }

/*
        Este evento se ejecuta al hacer clic en el botón para volver al menú.
Cierra la ventana actual y abre una nueva instancia del formulario frmRegistros.*/
        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            frmRegistros frmRe = new frmRegistros();
            frmRe.Show();
        }

    
    }
}
