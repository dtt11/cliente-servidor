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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        

        private void btnRegistrarForm_Click(object sender, EventArgs e)
        {
            // Cierra el formulario actual
            this.Hide();
            frmRegistros formRegistros = new frmRegistros();
            formRegistros.Show();
        }
        
       private void btnConsultarForm_Click(object sender, EventArgs e)
       {
           // Cierra el formulario actual
           this.Hide();
           frmConsulta formConsultarFormularios = new frmConsulta();
           formConsultarFormularios.Show();
       }

        private void btnServidor_Click(object sender, EventArgs e)
        {
            this.Close();
            BitacoraServidor frmbitacoraServidor = new BitacoraServidor();
            frmbitacoraServidor.Show();
        }
    }
}
