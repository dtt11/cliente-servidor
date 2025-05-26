using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace CapaGrafica.Forms
{
    public partial class frmMenuPrincipal : Form
    {
        private ClienteEntidad clienteActual;
        private TcpClient cliente;
        private StreamWriter escritor;
        private StreamReader lector;
        public frmMenuPrincipal(ClienteEntidad clienteActual, TcpClient cliente, StreamWriter escritor, StreamReader lector)
        {
            InitializeComponent();
            this.clienteActual = clienteActual;
            this.cliente = cliente;
            this.escritor = escritor;
            this.lector = lector;
        }
   

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                lector?.Close();
                escritor?.Close();
                cliente?.Close();
            }
            catch (Exception) { }

            Environment.Exit(0);
        }


        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVerReservas frmConsultar = new frmVerReservas(clienteActual);
            frmConsultar.Show();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReservas frmreservar = new frmReservas(clienteActual);
            frmreservar.Show();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = $"Usuario: {clienteActual.NombreCompleto}";
        }
    }
}
