using System;
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
    public partial class frmTipoVideojuegos : Form
    {
     private readonly LogicaTipoVideojuego logicaTipoVideojuego;

        public frmTipoVideojuegos()
        {
            InitializeComponent();
            logicaTipoVideojuego = new LogicaTipoVideojuego();
        }

        // Método para obtener los datos del formulario y convertirlos en una entidad
        private TipoVideojuegoEntidad ObtenerDatosFormulario()
        {
            if (!ValidarEntradas())
                return null;

            try
            {
                return new TipoVideojuegoEntidad
                {
                    // El ID no se asigna porque es autoincremental en la BD
                    Nombre = txtTipoVideojuego.Text.Trim(),
                    Descripcion = txtDescripcionVideojuego.Text.Trim()
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
            if (string.IsNullOrWhiteSpace(txtTipoVideojuego.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcionVideojuego.Text))
            {
                MostrarAdvertencia("Todos los campos son requeridos");
                return false;
            }

            if (txtTipoVideojuego.Text.Length > 40)
            {
                MostrarAdvertencia("El nombre no puede exceder 40 caracteres");
                return false;
            }

            return true;
        }

        // Método para limpiar los campos del formulario
        private void LimpiarFormulario()
        {
            txtTipoVideojuego.Clear();
            txtDescripcionVideojuego.Clear();
            txtTipoVideojuego.Focus();
        }
        // Evento: guardar los datos del tipovideojuego
        private void btnGuardarTipoVideojuego_Click(object sender, EventArgs e)
        {
            var tipoVideojuego = ObtenerDatosFormulario();
            if (tipoVideojuego == null) return;

            if (logicaTipoVideojuego.Insertar(tipoVideojuego, out string mensaje))
            {
                MostrarExito(mensaje);
                LimpiarFormulario();
            }
            else
            {
                MostrarError(mensaje);
            }
        }

        // Métodos auxiliares para mostrar mensajes
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
