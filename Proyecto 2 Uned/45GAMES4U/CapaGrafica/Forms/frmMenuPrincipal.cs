using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaGrafica.Forms
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReservas frmreservar = new frmReservas();
            frmreservar.Show();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVerReservas frmConsultar = new frmVerReservas();
            frmConsultar.Show();
        }
    }
}
