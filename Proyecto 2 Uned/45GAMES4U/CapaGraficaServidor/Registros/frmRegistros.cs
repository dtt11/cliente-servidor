using System;
using System.Windows.Forms;
using CapaGraficaServidor.Registros;
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
    public partial class frmRegistros : Form
    {
        public frmRegistros()
        {
            InitializeComponent();
        }

        private void btntiposVideoJuegos_Click(object sender, EventArgs e)
        {
            this.Close();
            frmTipoVideojuegos frmTipoVideojuegos = new frmTipoVideojuegos();
            frmTipoVideojuegos.Show();
        }

     
        
         private void btnAdministradoresTiendas_Click(object sender, EventArgs e)
         {
            this.Close();
            frmAdministradores frmadmi = new frmAdministradores();
            frmadmi.Show();
        }

       

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal frmPrincipal = new FormPrincipal();
            frmPrincipal.Show();
        }

        private void btnVideoJuegos_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmVideojuegos frmVideojuegos = new frmVideojuegos();
            frmVideojuegos.Show();
        }

        private void btnTiendas_Click(object sender, EventArgs e)
        {
            this.Close();
            frmTiendas frmtiendas = new frmTiendas();
            frmtiendas.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            this.Close();
            frmClientes frmClientes = new frmClientes();
            frmClientes.Show();
        }
        
  
        private void btnInventario_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmInventario frmInventario = new frmInventario();
            frmInventario.Show();
        }
    }
}