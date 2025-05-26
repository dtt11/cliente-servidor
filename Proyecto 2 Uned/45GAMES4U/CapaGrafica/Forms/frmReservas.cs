using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaGrafica.Forms;
using CapaEntidades;
using CapaLogica;
using Newtonsoft.Json;
using System.IO;
using System.Net.Sockets;

namespace CapaGrafica
{
    public partial class frmReservas : Form
    {

        private ClienteEntidad clienteActual;

        public frmReservas(ClienteEntidad cliente)
        {
            InitializeComponent();
            clienteActual = cliente;
            CargarTiendas();
        }

        private void CargarTiendas()
        {
            try
            {
                using (TcpClient cliente = new TcpClient("127.0.0.1", 14100))
                using (NetworkStream stream = cliente.GetStream())
                using (StreamWriter escritor = new StreamWriter(stream))
                using (StreamReader lector = new StreamReader(stream))
                {
                    escritor.WriteLine("TIENDAS");
                    escritor.Flush();

                    string json = lector.ReadLine();
                    var tiendas = JsonConvert.DeserializeObject<List<TiendaEntidad>>(json);

                    cmbTienda.Items.Clear();

                    foreach (var tienda in tiendas)
                        if (tienda.Activa)
                            cmbTienda.Items.Add(tienda);

                    cmbTienda.DisplayMember = "Nombre";
                    cmbTienda.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tiendas: " + ex.Message);
            }
        }


        private void cmbTienda_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tienda = cmbTienda.SelectedItem as TiendaEntidad;

            if (tienda == null) return;

            try
            {
                using (TcpClient cliente = new TcpClient("127.0.0.1", 14100))
                using (NetworkStream stream = cliente.GetStream())
                using (StreamWriter escritor = new StreamWriter(stream))
                using (StreamReader lector = new StreamReader(stream))
                {
                    escritor.WriteLine("INVENTARIO");
                    escritor.WriteLine(tienda.Id.ToString());
                    escritor.Flush();

                    string json = lector.ReadLine();
                    var inventario = JsonConvert.DeserializeObject<List<VideojuegosXTiendaEntidad>>(json);

                    dgvInventario.DataSource = null;
                    dgvInventario.DataSource = inventario;

                    dgvInventario.Columns["Existencias"].HeaderText = "Existencias";
                    dgvInventario.Columns["Videojuego"].HeaderText = "Videojuego";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar inventario: " + ex.Message);
            }
        }

  

        private void EnviarReservaAlServidor(ReservaEntidad reserva)
        {
            try
            {
                TcpClient cliente = new TcpClient("127.0.0.1", 14100);
                NetworkStream stream = cliente.GetStream();
                StreamWriter escritor = new StreamWriter(stream);
                StreamReader lector = new StreamReader(stream);

                string mensaje = JsonConvert.SerializeObject(reserva);
                escritor.WriteLine("RESERVAR"); // Comando
                escritor.WriteLine(mensaje);
                escritor.Flush();

                string respuesta = lector.ReadLine();
                if (respuesta == "OK")
                    MessageBox.Show("Reserva realizada con éxito.");
                else
                    MessageBox.Show("Error: " + respuesta);

                lector.Close();
                escritor.Close();
                cliente.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
            }
        }

    

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmMenuPrincipal frmMenu = new frmMenuPrincipal();
            frmMenu.Show();
        }

        private void btnReservar_Click_1(object sender, EventArgs e)
        {
            if (dgvInventario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un videojuego.");
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.");
                return;
            }

            var videojuegoXTienda = dgvInventario.SelectedRows[0].DataBoundItem as VideojuegosXTiendaEntidad;

            var reserva = new ReservaEntidad
            {
                VideojuegoPorTienda = videojuegoXTienda,
                Cliente = clienteActual,
                FechaReserva = DateTime.Now,
                Cantidad = cantidad
            };

            EnviarReservaAlServidor(reserva);
        }
    }
}
