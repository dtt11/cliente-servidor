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
using Newtonsoft.Json;

namespace CapaGrafica.Forms
{
    public partial class frmVerReservas : Form
    {

        private ClienteEntidad clienteActual;
        private TcpClient cliente;
        private StreamWriter escritor;
        private StreamReader lector;

        public frmVerReservas(ClienteEntidad cliente)
        {
            InitializeComponent();
            clienteActual = cliente;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuPrincipal frmMenu = new frmMenuPrincipal(clienteActual, cliente, escritor, lector);
            frmMenu.Show();
        }
        // Evento que maneja la acción de consultar las reservas del cliente en el servidor.
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dgvReservas.DataSource = null;

            try
            {
                using (TcpClient cliente = new TcpClient("127.0.0.1", 14100))
                using (NetworkStream stream = cliente.GetStream())
                using (StreamWriter escritor = new StreamWriter(stream) { AutoFlush = true })
                using (StreamReader lector = new StreamReader(stream))
                {
                    // Enviar comando y el ID del cliente
                    escritor.WriteLine("CONSULTAR");
                    escritor.WriteLine(clienteActual.Id.ToString());

                    // Leer respuesta JSON
                    string json = lector.ReadLine();

                    var reservas = JsonConvert.DeserializeObject<List<ReservaEntidad>>(json);

                    if (reservas == null || reservas.Count == 0)
                    {
                        MessageBox.Show("No se encontraron reservas para este cliente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    var tabla = new DataTable();
                    tabla.Columns.Add("Tienda");
                    tabla.Columns.Add("Videojuego");
                    tabla.Columns.Add("Fecha");
                    tabla.Columns.Add("Cantidad");

                    foreach (var r in reservas)
                    {
                        tabla.Rows.Add(
                            r.VideojuegoPorTienda.Tienda.Nombre,
                            r.VideojuegoPorTienda.Videojuego.Nombre,
                            r.FechaReserva.ToShortDateString(),
                            r.Cantidad
                        );
                    }
                    //Cargar el dgv
                    dgvReservas.DataSource = tabla;
                    dgvReservas.ReadOnly = true;
                    dgvReservas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvReservas.MultiSelect = false;
                    dgvReservas.AllowUserToAddRows = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar reservas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
