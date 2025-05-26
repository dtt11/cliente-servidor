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
    public partial class frmConsultarTiendas : Form
    {
        private readonly LogicaTienda logicaTienda;
        public frmConsultarTiendas()
        {
            InitializeComponent();
            logicaTienda = new LogicaTienda();
        }

        private void MostrarDatosEnGrid()
        {
            var tiendas = logicaTienda.ObtenerTodos(out string mensaje);

            if (!string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var tabla = new System.Data.DataTable();
            tabla.Columns.Add("ID");
            tabla.Columns.Add("Tienda");
            tabla.Columns.Add("Dirección");
            tabla.Columns.Add("Teléfono");
            tabla.Columns.Add("Activa");
            tabla.Columns.Add("Administrador");
            tabla.Columns.Add("Fecha Contratación Admin");

            foreach (var t in tiendas)
            {
                tabla.Rows.Add(
                    t.Id,
                    t.Nombre,
                    t.Direccion,
                    t.Telefono,
                    t.Activa ? "Sí" : "No",
                    t.Administrador?.NombreCompleto,
                    t.Administrador.FechaContratacion.ToString("dd/MM/yyyy")
                );
            }

            dgvTiendas.DataSource = tabla;
            // Ajustar la edicion de la tabla
            dgvTiendas.ReadOnly = true;
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            frmConsulta frmCon = new frmConsulta();
            frmCon.Show();
        }

        private void btnConsultarTiendas_Click(object sender, EventArgs e)
        {
            MostrarDatosEnGrid();
        }
    }
}
