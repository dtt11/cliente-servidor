using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaGraficaServidor;
using CapaGraficaServidor.Consultas;
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
    public partial class frmConsulta : Form
    {
        public frmConsulta()
        {
            InitializeComponent();
        }

        private void btnConsultartiposVideoJuegos_Click(object sender, EventArgs e)
        {
            this.Close();
            frmConsultarTiposVideojuegos frmConsultarTiposVideojuegos = new frmConsultarTiposVideojuegos();
            frmConsultarTiposVideojuegos.Show();
        }
       
        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal frmPrincipal = new FormPrincipal();
            frmPrincipal.Show();
        }

        private void btnConsultarVideoJuegos_Click(object sender, EventArgs e)
        {
            this.Close();
            frmConsultarVideojuegos frmConsultarVideojuegos = new frmConsultarVideojuegos();
            frmConsultarVideojuegos.Show();
        }

        private void btnConsultarAdministradoresTiendas_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmConsultarAdministradores frmConsultarAdmi = new frmConsultarAdministradores();
            frmConsultarAdmi.Show();
        }

        private void btnConsultarTiendas_Click(object sender, EventArgs e)
        {
            this.Close();
            frmConsultarTiendas frmconsultartiendas = new frmConsultarTiendas();
            frmconsultartiendas.Show();
        }

        private void btnConsultarClientes_Click(object sender, EventArgs e)
        {
            this.Close();
            frmConsultarClientes frmconsultarclientes = new frmConsultarClientes();
            frmconsultarclientes.Show();
        }

        private void btnConsultarInventario_Click(object sender, EventArgs e)
        {
            this.Close();
            frmConsultarInventario frmconsultarinventario = new frmConsultarInventario();
            frmconsultarinventario.Show();
        }




    }
}
