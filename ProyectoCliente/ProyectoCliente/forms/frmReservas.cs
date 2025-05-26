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
using System.IO;
using System.Net.Sockets;
using Entidades;
using Newtonsoft.Json;

namespace CapaGrafica
{
    public partial class frmReservas : Form
    {
        private ClienteEntidad clienteActual;
        private TcpClient cliente;
        private StreamWriter escritor;
        private StreamReader lector;



        public frmReservas(ClienteEntidad cliente)
        {
            InitializeComponent();
            clienteActual = cliente;
            CargarCli();
            cmbTienda.SelectedIndexChanged += cmbTienda_SelectedIndexChanged;
            CargarTiendas();
           
        }

        // Configura la conexión TCP con el servidor y crea los objetos necesarios para la comunicación.
        private void CargarCli()
        {
            cliente = new TcpClient("127.0.0.1", 14100);
            var stream = cliente.GetStream();
            escritor = new StreamWriter(stream) { AutoFlush = true };
            lector = new StreamReader(stream);
        }

        // Solicita al servidor una lista de tiendas activas y las carga en el comboBox.
        private void CargarTiendas()
        {
            try
            {
                escritor.WriteLine("TIENDAS");
                string json = lector.ReadLine();

                var tiendas = JsonConvert.DeserializeObject<List<TiendaEntidad>>(json);

                cmbTienda.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbTienda.DataSource = tiendas.Where(t => t.Activa).ToList();
                cmbTienda.DisplayMember = "Nombre";
                cmbTienda.ValueMember = "Id";

                if (cmbTienda.Items.Count > 0)
                    cmbTienda.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tiendas: " + ex.Message);
            }
        }



        // Solicita al servidor una lista de tiendas activas y las carga en el comboBox.
        private async void cmbTienda_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tienda = cmbTienda.SelectedItem as TiendaEntidad;
            if (tienda == null) return;

            try
            {
                await escritor.WriteLineAsync("INVENTARIO");
                await escritor.WriteLineAsync(tienda.Id.ToString());

                string json = await lector.ReadLineAsync();
                var inventario = JsonConvert.DeserializeObject<List<VideojuegosXTiendaEntidad>>(json);

                if (inventario == null || inventario.Count == 0)
                {
                    dgvInventario.DataSource = null;
                    MessageBox.Show("Esta tienda no tiene videojuegos registrados.", "Aviso");
                    return;
                }

                // Limpiar el DataSource y eliminar columnas adicionales
                dgvInventario.DataSource = null;

                // Asignar el DataSource
                dgvInventario.DataSource = inventario;

                // Eliminar las columnas duplicadas si existen
                if (dgvInventario.Columns.Contains("NombreVideojuego"))
                {
                    dgvInventario.Columns.Remove("NombreVideojuego");
                }

                if (dgvInventario.Columns.Contains("Unidades"))
                {
                    dgvInventario.Columns.Remove("Unidades");
                }

                // Configuración de las columnas de video juego y existencias
                dgvInventario.Columns["Tienda"].Visible = false; // Ocultar columna "Tienda"
                dgvInventario.Columns["Videojuego"].Visible = false; // Ocultar columna "Videojuego"

                // Agregar las columnas correctamente
                dgvInventario.Columns.Add("NombreVideojuego", "Videojuego");
                dgvInventario.Columns.Add("Unidades", "Existencias");

                // Asignar los valores de las nuevas columnas
                foreach (DataGridViewRow fila in dgvInventario.Rows)
                {
                    var item = fila.DataBoundItem as VideojuegosXTiendaEntidad;
                    fila.Cells["NombreVideojuego"].Value = item?.Videojuego?.Nombre;
                    fila.Cells["Unidades"].Value = item?.Existencias;
                }

                // Configuración final para el DataGridView
                dgvInventario.ReadOnly = true;
                dgvInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvInventario.MultiSelect = false;
                dgvInventario.AllowUserToAddRows = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar inventario: " + ex.Message);
            }
        }




        // Envia la información de la reserva al servidor para ser procesada y registrada.

        private void EnviarReservaAlServidor(ReservaEntidad reserva)
        {
            try
            {
                escritor.WriteLine("RESERVAR");
                string mensaje = JsonConvert.SerializeObject(reserva);
                escritor.WriteLine(mensaje);

                string respuesta = lector.ReadLine();
                if (respuesta == "OK")
                    MessageBox.Show("Reserva realizada con éxito.");
                else
                    MessageBox.Show("Error: " + respuesta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
            }
        }



        // Evento volver al menú principal.
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenuPrincipal frmMenu = new frmMenuPrincipal(clienteActual, cliente, escritor, lector);
            frmMenu.Show();
        }

        // Evento realizar una reserva.
        private void btnReservar_Click(object sender, EventArgs e)
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

            if (videojuegoXTienda == null || videojuegoXTienda.Videojuego == null || videojuegoXTienda.Tienda == null)
            {
                MessageBox.Show("Error al recuperar la información del videojuego.");
                return;
            }

            var reserva = new ReservaEntidad
            {
                VideojuegoPorTienda = videojuegoXTienda,
                Cliente = clienteActual,
                FechaReserva = DateTime.Now,
                Cantidad = cantidad
            };

            EnviarReservaAlServidor(reserva); // Realiza la reserva
        }
    }
}


       