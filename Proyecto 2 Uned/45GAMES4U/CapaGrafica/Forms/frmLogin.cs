using System;
using System.Net.Sockets;
using System.Windows.Forms;
using System.IO;
using CapaGrafica.Forms;

namespace CapaGrafica
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdCliente.Text.Trim(), out int idCliente) || idCliente <= 0)
            {
                MessageBox.Show("La identificación debe ser un número válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (TcpClient cliente = new TcpClient())
                {
                    await cliente.ConnectAsync("127.0.0.1", 14100); // Cliente asincrónico
                    using (NetworkStream stream = cliente.GetStream())
                    using (StreamWriter escritor = new StreamWriter(stream))
                    using (StreamReader lector = new StreamReader(stream))
                    {
                        escritor.AutoFlush = true;

                        // Enviar el ID del cliente al servidor
                        await escritor.WriteLineAsync(idCliente.ToString());

                        // Leer la respuesta del servidor
                        string respuesta = await lector.ReadLineAsync();

                        if (respuesta == "OK")
                        {
                            MessageBox.Show("Conexión exitosa. Cliente válido.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            entrarMenu();
                        }
                        else
                        {
                            MessageBox.Show("Cliente no registrado.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (SocketException ex)
            {
                MessageBox.Show($"No se pudo conectar con el servidor.\n{ex.Message}", "Error de red", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void entrarMenu()
        {
            this.Hide();
            frmMenuPrincipal frmMenu = new frmMenuPrincipal();
            frmMenu.Show();
        }
    }
}
