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
    public partial class frmConsultarClientes : Form
    {
        private readonly LogicaCliente logicaCliente;
        public frmConsultarClientes()
        {
            InitializeComponent();
            logicaCliente = new LogicaCliente();
        }
        private void MostrarClientes()
        {
            var lista = logicaCliente.ObtenerTodos(out string mensaje);

            if (!string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var tabla = new DataTable();
            tabla.Columns.Add("Identificación");
            tabla.Columns.Add("Nombre completo");
            tabla.Columns.Add("Fecha de nacimiento");
            tabla.Columns.Add("Jugador en línea");

            foreach (var c in lista)
            {
                tabla.Rows.Add(
                    c.Id,
                    c.NombreCompleto,
                    c.FechaNacimiento.ToShortDateString(),
                    c.JugadorEnLinea ? "Sí" : "No"
                );
            }

            dgvClientes.DataSource = tabla;
            dgvClientes.ReadOnly = true;
            
        }
        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            frmConsulta frmCon = new frmConsulta();
            frmCon.Show();
        }

        private void btnConsultarClientes_Click(object sender, EventArgs e)
        {
            MostrarClientes();
        }
    }
}
