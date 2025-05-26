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
    public partial class frmConsultarTiposVideojuegos : Form
    {
        private readonly LogicaTipoVideojuego logicaTipoVideojuego;

        public frmConsultarTiposVideojuegos()
        {
            InitializeComponent();
            logicaTipoVideojuego = new LogicaTipoVideojuego();
        }

        private void MostrarDatosEnGrid()
        {
            // Usando el método de la capa lógica con manejo de errores
            var resultado = logicaTipoVideojuego.ObtenerTodos(out string mensaje);

            if (!string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvTiposVideojuegos.DataSource = resultado;

            // Configurar los encabezados de las columnas
            dgvTiposVideojuegos.Columns[0].HeaderText = "ID";
            dgvTiposVideojuegos.Columns[1].HeaderText = "Tipo de Videojuego";
            dgvTiposVideojuegos.Columns[2].HeaderText = "Descripción";

            // Ajustar la edicion de la tabla
            dgvTiposVideojuegos.ReadOnly = true;
        }

        private void btnConsultarTiposVideojuegos_Click(object sender, EventArgs e)
        {
            MostrarDatosEnGrid();
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            
             this.Close();
            frmConsulta frmCon = new frmConsulta();
            frmCon.Show();

        }
    }
}