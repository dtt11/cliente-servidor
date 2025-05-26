using System;
using System.Net.Sockets;// Para conexiones TCP
using System.Windows.Forms;
using System.IO;    
using CapaGrafica.Forms;
using Entidades;
using Newtonsoft.Json;// Para serializar/deserializar objetos (JSON)

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
            Application.Exit();// Evento click del botón "Salir": cierra toda la aplicación
        }

        // Evento click del botón "Ingresar": valida el ID ingresado, se conecta al servidor, envía el ID y muestra el menú si es válido
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
                    await cliente.ConnectAsync("127.0.0.1", 14100);
                    using (NetworkStream stream = cliente.GetStream())
                    using (StreamWriter escritor = new StreamWriter(stream) { AutoFlush = true })
                    using (StreamReader lector = new StreamReader(stream))
                    // Establece una conexión TCP asíncrona con el servidor en localhost:14100, 
                    // luego obtiene el flujo de red para enviar y recibir datos mediante un StreamWriter (para enviar datos) 
                    // y un StreamReader (para leer datos), asegurando que los mensajes enviados se escriban inmediatamente (AutoFlush).

                    {
                        // Enviar comando VALIDAR
                        await escritor.WriteLineAsync("VALIDAR");

                        // Enviar ID del cliente
                        await escritor.WriteLineAsync(idCliente.ToString());

                        // Leer respuesta del servidor
                        string respuesta = await lector.ReadLineAsync();

                        if (respuesta == "OK")
                        {
                            string nombreCompleto = await lector.ReadLineAsync(); 
                            var clienteEntidad = new ClienteEntidad
                            {
                                Id = idCliente,
                                Nombre = nombreCompleto
                            };

                            MessageBox.Show("Conexión exitosa. Cliente válido.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Mostrar menú principal
                            this.Hide();
                            frmMenuPrincipal frmMenu = new frmMenuPrincipal(clienteEntidad, cliente, escritor, lector);
                            frmMenu.Show();
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
    }
}
