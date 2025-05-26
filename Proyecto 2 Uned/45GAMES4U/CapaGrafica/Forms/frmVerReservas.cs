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
    public partial class frmVerReservas : Form
    {
        public frmVerReservas()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenuPrincipal frmMenu = new frmMenuPrincipal();
            frmMenu.Show();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }
    }
}
