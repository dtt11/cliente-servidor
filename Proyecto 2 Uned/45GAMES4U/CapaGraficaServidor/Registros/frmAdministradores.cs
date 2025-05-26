using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    public partial class frmAdministradores : Form
    {
        private readonly LogicaAdministrador logicaAdministrador;
        // Instancia de la lógica de negocios para administradores

       
        public frmAdministradores()
        {
            InitializeComponent();
            logicaAdministrador = new LogicaAdministrador();
         

           
        }
        // Método para obtener los datos del formulario y convertirlos en una entidad

        private AdministradorEntidad ObtenerDatosFormulario()
        {
            if (!ValidarEntradas())
                return null;

            try
            {
                return new AdministradorEntidad
                {
                    Id = int.Parse(txtIdentificacion.Text.Trim()),
                    Nombre = txtNombre.Text.Trim(),
                    PrimerApellido = txtPrimerApellido.Text.Trim(),
                    SegundoApellido = txtSegundoApellido.Text.Trim(),
                    FechaNacimiento = dtpNacimiento.Value.Date,
                    FechaContratacion = dtpContratacion.Value.Date
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
            if (string.IsNullOrWhiteSpace(txtIdentificacion.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtPrimerApellido.Text) ||
                string.IsNullOrWhiteSpace(txtSegundoApellido.Text))
            {
                MostrarAdvertencia("Todos los campos son requeridos.");
                return false;
            }

            if (!int.TryParse(txtIdentificacion.Text, out int id) || id <= 0)
            {
                MostrarAdvertencia("La identificación debe ser un número entero positivo.");
                return false;
            }

            if (dtpNacimiento.Value >= DateTime.Today.AddYears(-18))
            {
                MostrarAdvertencia("El administrador debe ser mayor de edad.");
                return false;
            }

            if (dtpContratacion.Value > DateTime.Today)
            {
                MostrarAdvertencia("La fecha de contratación no puede ser futura.");
                return false;
            }

            return true;
        }

        // Método para limpiar los campos del formulario
        private void LimpiarFormulario()
        {
            txtIdentificacion.Clear();
            txtNombre.Clear();
            txtPrimerApellido.Clear();
            txtSegundoApellido.Clear();
            dtpNacimiento.Value = DateTime.Today;
            dtpContratacion.Value = DateTime.Today;
            txtIdentificacion.Focus();
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
        private void btnVolverMenu_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmRegistros frmRe = new frmRegistros();
            frmRe.Show();
        }
        // Evento: guardar los datos del administrador
        private void btnGuardarTiendas_Click(object sender, EventArgs e)
        {
            var administrador = ObtenerDatosFormulario();
            if (administrador == null) return;

            if (logicaAdministrador.Insertar(administrador, out string mensaje))
            {
                MostrarExito(mensaje);
                LimpiarFormulario();
            }
            else
            {
                MostrarError(mensaje);
            }
        }
    }
}
