using System;
using System.Net;
using System.Net.Sockets;// Para conexiones TCP
using System.Threading; // Para SemaphoreSlim y Thread-Safe counters
using System.Threading.Tasks;// Para Task.Run y async/await
using System.Windows.Forms;
using CapaLogica;
using System.IO;// Para StreamReader y StreamWriter
using CapaEntidades;
using Newtonsoft.Json;// Para serializar/deserializar objetos (JSON)
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



/*
 Referencias del codigo:
Felipe Gavilan Programa. (2020, 26 octubre). 16 - 
Semáforo - Entendiendo SemaphoreSlim en C# - Programación Asíncrona [Vídeo]. YouTube. https://www.youtube.com/watch?v=jjdJxVGKKG0

Profe Maty. (2020, 22 abril). Creando un servidor y un cliente con sockets [Vídeo]. YouTube. https://www.youtube.com/watch?v=4JIuR5REknE
 
 */
namespace CapaGraficaServidor   
{  
    public partial class BitacoraServidor : Form
    {
        //Declaración de clase y variables
        private TcpListener servidor;
        private bool servidorActivo = false;
        private int clientesConectados = 0;
        private readonly SemaphoreSlim limiteConexiones = new SemaphoreSlim(5); // máximo 5 conexiones activas

        public BitacoraServidor()
        {
            InitializeComponent();//Inicializa la interfaz gráfica.
           lblClientes.Text = "Clientes conectados: 0"; //Configura el Label con el contador de clientes conectados.

        }
        // Botón para iniciar el servidor
        private void btnIniciarServidor_Click(object sender, EventArgs e)
        {
            if (!servidorActivo)
            {
                servidorActivo = true;
                Task.Run(() => EscucharClientes());
                MessageBox.Show("Servidor iniciado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El servidor ya está en ejecución.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // Escucha de clientes entrantes
        private void EscucharClientes()
        {
            try
            {
                servidor = new TcpListener(IPAddress.Any, 14100);//"Escuchá conexiones TCP en cualquier IP de mi computadora, en el puerto 14100".
                servidor.Start();

                while (servidorActivo)
                {
                    TcpClient cliente = servidor.AcceptTcpClient();
                    Task.Run(() => ManejarCliente(cliente));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en el servidor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Manejo de cada cliente conectado
        private async void ManejarCliente(TcpClient cliente)
        {
            await limiteConexiones.WaitAsync();
            Interlocked.Increment(ref clientesConectados);
            ActualizarLabelClientes();
            AgregarABitacora("Cliente conectado.");


            // Comunicación con el cliente
            try
            {
                using (cliente)
                using (NetworkStream stream = cliente.GetStream())
                using (StreamReader lector = new StreamReader(stream))
                using (StreamWriter escritor = new StreamWriter(stream) { AutoFlush = true })
                {
                    while (true)
                    {
                        string comando = await lector.ReadLineAsync();
                        if (comando == null) break;

                        switch (comando.Trim().ToUpper())
                        {
                            case "VALIDAR":
                                {
                                    try
                                    {
                                        string idTexto = await lector.ReadLineAsync();
                                        if (int.TryParse(idTexto, out int idCliente))
                                        {
                                            var logicaCliente = new LogicaCliente();
                                            string resultado = logicaCliente.ValidarCliente(idCliente); // Devuelve "OK|NombreCompleto" o "ERROR|mensaje"

                                            string[] partes = resultado.Split('|');
                                            if (partes.Length >= 2 && partes[0] == "OK")
                                            {
                                                string nombreCompleto = partes[1];
                                                await escritor.WriteLineAsync("OK");
                                                await escritor.WriteLineAsync(nombreCompleto);
                                                AgregarABitacora($"VALIDAR: Cliente {idCliente} autenticado como {nombreCompleto}");
                                            }
                                            else
                                            {
                                                await escritor.WriteLineAsync("ERROR");
                                                AgregarABitacora($"VALIDAR: Cliente {idCliente} no válido → {partes[1]}");
                                            }
                                        }
                                        else
                                        {
                                            await escritor.WriteLineAsync("ERROR");
                                            AgregarABitacora("VALIDAR: ID recibido no es válido.");
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        await escritor.WriteLineAsync("ERROR");
                                        AgregarABitacora($"VALIDAR: Excepción inesperada - {ex.Message}");
                                    }
                                    break;
                                }


                            case "TIENDAS":
                                {

                                    /*
                                     Obtiene todas las tiendas usando LogicaTienda.
                                    Serializa y envía la lista en formato JSON.
                                     */
                                    var logicaTienda = new LogicaTienda();
                                    var tiendas = logicaTienda.ObtenerTodos(out string msg);
                                    string json = JsonConvert.SerializeObject(tiendas);
                                    await escritor.WriteLineAsync(json);
                                    AgregarABitacora("TIENDAS: Lista enviada.");
                                    break;
                                }

                            case "INVENTARIO":
                                {
                                    /*Lee el ID de la tienda, obtiene su inventario con LogicaVideojuegosXTienda, y lo envía en JSON.

                                    Si el ID es inválido, responde con un arreglo vacío ([]).*/
                                    string idTexto = await lector.ReadLineAsync();
                                    if (int.TryParse(idTexto, out int idTienda))
                                    {
                                        var logicaInv = new LogicaVideojuegosXTienda();
                                        var inventario = logicaInv.ObtenerPorTienda(idTienda, out string msg);
                                        string json = JsonConvert.SerializeObject(inventario);
                                        await escritor.WriteLineAsync(json);
                                        AgregarABitacora($"INVENTARIO: Enviado inventario de tienda {idTienda}.");
                                    }
                                    else
                                    {
                                        await escritor.WriteLineAsync("[]");
                                        AgregarABitacora("INVENTARIO: ID inválido.");
                                    }
                                    break;
                                }

                            case "RESERVAR":
                                {

                                    /*Lee un objeto reserva en formato JSON desde el cliente.

                                    Lo deserializa a una instancia de ReservaEntidad.

                                    Llama a GuardarReserva para intentar registrar la reserva.

                                    Informa al cliente si se registró correctamente (OK) o hubo un error (ERROR: mensaje).

                                    Guarda en la bitácora lo que ocurrió.*/
                                    string jsonReserva = await lector.ReadLineAsync();
                                    var reserva = JsonConvert.DeserializeObject<ReservaEntidad>(jsonReserva);

                                    var logicaReserva = new LogicaReserva();
                                    bool resultado = logicaReserva.GuardarReserva(reserva, out string mensaje);

                                    if (resultado)
                                    {
                                        await escritor.WriteLineAsync("OK");
                                        AgregarABitacora($"RESERVAR: Reserva registrada para cliente {reserva.Cliente.Id}");
                                    }
                                    else
                                    {
                                        await escritor.WriteLineAsync("ERROR: " + mensaje);
                                        AgregarABitacora($"RESERVAR: Error al registrar reserva - {mensaje}");
                                    }
                                    break;
                                }

                            case "CONSULTAR":
                                {
                                    /*Lee un ID de cliente y lo valida.

                                    Usa LogicaReserva para obtener las reservas de ese cliente.

                                    Si hay un error, responde con arreglo vacío ([]) y lo registra en la bitácora.

                                    Si tiene reservas, las serializa y las envía.*/
                                    string idTexto = await lector.ReadLineAsync();
                                    if (int.TryParse(idTexto, out int idConsulta))
                                    {
                                        var logicaReserva = new LogicaReserva();
                                        var reservas = logicaReserva.ConsultarPorCliente(idConsulta, out string mensaje);

                                        if (!string.IsNullOrEmpty(mensaje))
                                        {
                                            AgregarABitacora($"CONSULTAR: Error al consultar cliente {idConsulta}: {mensaje}");
                                            await escritor.WriteLineAsync("[]");
                                        }
                                        else
                                        {
                                            string json = JsonConvert.SerializeObject(reservas);
                                            await escritor.WriteLineAsync(json);
                                            AgregarABitacora($"CONSULTAR: Enviadas {reservas.Count} reservas de cliente {idConsulta}.");
                                        }
                                    }
                                    else
                                    {
                                        await escritor.WriteLineAsync("[]");
                                        AgregarABitacora("CONSULTAR: ID inválido.");
                                    }
                                    break;
                                }

                            default:
                                await escritor.WriteLineAsync("ERROR: Comando no reconocido.");
                                AgregarABitacora($"Comando no reconocido: {comando}");
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                AgregarABitacora("Error manejando cliente: " + ex.Message);
            }
            finally
            {
                /*Cierre de conexión del cliente*/
                Interlocked.Decrement(ref clientesConectados);
                ActualizarLabelClientes();
                AgregarABitacora("Cliente desconectado.");
                limiteConexiones.Release();
            }
        }


        //Método para registrar en la bitácora
        private void AgregarABitacora(string mensaje)
        {
            if (lstBitacora.InvokeRequired)
            {
                lstBitacora.Invoke(new Action(() => lstBitacora.Items.Add($"{mensaje}")));
            }
            else
            {
                lstBitacora.Items.Add($"{mensaje}");
            }
        }


        //Actualizar número de clientes conectados
        private void ActualizarLabelClientes()
        {
            if (lblClientes.InvokeRequired)
            {
                lblClientes.Invoke(new Action(ActualizarLabelClientes));
            }
            else
            {
                lblClientes.Text = $"Clientes conectados: {clientesConectados}";
            }
        }
        // Ir al menú principal
        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal frmPrincipal = new FormPrincipal();
            frmPrincipal.Show();
        }

        //Cerrar toda la aplicación
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
