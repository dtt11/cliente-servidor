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
namespace CapaGraficaServidor.Consultas
{
    public partial class frmConsultarAdministradores : Form
    {
        private readonly LogicaAdministrador logicaAdministrador;

        public frmConsultarAdministradores()
        {
            InitializeComponent();
            logicaAdministrador = new LogicaAdministrador();
        }

        private void MostrarDatosEnGrid()
        {
            var resultado = logicaAdministrador.ObtenerTodos(out string mensaje);

            if (!string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvAdministradores.DataSource = resultado;

            // Encabezados personalizados
            dgvAdministradores.Columns[0].HeaderText = "Fecha de Contratación";
            dgvAdministradores.Columns[1].HeaderText = "Identificación"; 
            dgvAdministradores.Columns[2].HeaderText = "Nombre";
            dgvAdministradores.Columns[3].HeaderText = "Primer Apellido";
            dgvAdministradores.Columns[4].HeaderText = "Segundo Apellido";
            dgvAdministradores.Columns[5].HeaderText = "Fecha de Nacimiento";

            // Opcional: Formatear fechas sin hora
            dgvAdministradores.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvAdministradores.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";

            // Ajustar la edicion de la tabla
            dgvAdministradores.ReadOnly = true;


        }

      

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            frmConsulta frmCon = new frmConsulta();
            frmCon.Show();
        }

        private void btnConsultarAdministradores_Click(object sender, EventArgs e)
        {
            MostrarDatosEnGrid();
        }
    }
}
