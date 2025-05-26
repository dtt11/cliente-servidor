using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
namespace CapaGraficaServidor.Consultas
{
    public partial class frmConsultarInventario : Form
    {
    
        private readonly LogicaVideojuegosXTienda logicaInventario;

        public frmConsultarInventario()
        {
            InitializeComponent();
            logicaInventario = new LogicaVideojuegosXTienda();
            CargarInventario();
        }

        private void CargarInventario()
        {
            dgvInventario.DataSource = null;

            var lista = logicaInventario.ObtenerTodos(out string mensaje);

            if (!string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, "Error al cargar el inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lista.Count == 0)
            {
                MessageBox.Show("No hay registros de inventario disponibles.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var tabla = new DataTable();
            tabla.Columns.Add("ID Tienda");
            tabla.Columns.Add("Nombre Tienda");
            tabla.Columns.Add("Dirección");
            tabla.Columns.Add("ID Videojuego");
            tabla.Columns.Add("Nombre Videojuego");
            tabla.Columns.Add("Tipo de Videojuego");
            tabla.Columns.Add("Existencias");

            foreach (var item in lista)
            {
                tabla.Rows.Add(
                    item.Tienda.Id,
                    item.Tienda.Nombre,
                    item.Tienda.Direccion,
                    item.Videojuego.Id,
                    item.Videojuego.Nombre,
                    item.Videojuego.TipoVideojuego?.NombreTipo ?? "Sin tipo", // protección nulo
                    item.Existencias
                );
            }

            dgvInventario.DataSource = tabla;

            // Configuración visual
            dgvInventario.ReadOnly = true;
            dgvInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventario.MultiSelect = false;
            dgvInventario.AllowUserToAddRows = false;
        }
        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            frmConsulta frmCon = new frmConsulta();
            frmCon.Show();
        }
    }
}
