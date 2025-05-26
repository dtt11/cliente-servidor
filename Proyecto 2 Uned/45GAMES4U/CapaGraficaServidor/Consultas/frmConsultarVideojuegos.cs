using System;
using System.Windows.Forms;
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
namespace CapaGraficaServidor
{
    public partial class frmConsultarVideojuegos : Form
    {
        private readonly LogicaVideojuego logicaVideojuego;

        public frmConsultarVideojuegos()
        {
            InitializeComponent();
            logicaVideojuego = new LogicaVideojuego();
        }

        private void MostrarDatosEnGrid()
        {
            // Usando el método de la capa lógica con manejo de errores
            var resultado = logicaVideojuego.ObtenerTodos(out string mensaje);

            if (!string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var tabla = new System.Data.DataTable();
            tabla.Columns.Add("ID");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Tipo");
            tabla.Columns.Add("Desarrollador");
            tabla.Columns.Add("Año de Lanzamiento");
            tabla.Columns.Add("Formato");

            foreach (var r in resultado)
            {
                tabla.Rows.Add(
                    r.Id,
                    r.Nombre,
                    r.TipoVideojuego?.NombreTipo,
                    r.Desarrollador,
                    r.Lanzamiento,
                    r.Fisico ? "Físico" : "Virtual"
                );
            }

            dgvVideojuegos.DataSource = tabla;

            // Ajustar la edicion de la tabla
            dgvVideojuegos.ReadOnly = true;
        }
        
        private void btnConsultarVideojuegos_Click(object sender, EventArgs e)
        {
            MostrarDatosEnGrid();
        }

        private void btnVolverMenu_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmConsulta frmCon = new frmConsulta();
            frmCon.Show();

        }
    }
}
