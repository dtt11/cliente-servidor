using System;
using System.Collections.Generic;
using System.Linq;
using CapaEntidades;
using CapaDatos;
using Newtonsoft.Json;
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
RJ Code Advance. (2018, 19 abril). CRUD con C#, WinForm, SQL Server, POO y Arquitectura en Capas- Nivel Básico
[Vídeo]. YouTube. https://www.youtube.com/watch?v=_H8vswpMSOw
 */
namespace CapaLogica
{
    public class LogicaCliente
    {
        private readonly ClienteBD datosCliente;

        public LogicaCliente()
        {
            datosCliente = new ClienteBD();
        }
        // Método que valida e inserta un nuevo cliente.
        public bool Insertar(ClienteEntidad cliente, out string mensaje)
        {
            mensaje = string.Empty;

            try
            {
                // ✅ Validaciones

                if (cliente.Id <= 0)
                {
                    mensaje = "La identificación es requerida y debe ser mayor que cero.";
                    return false;
                }

                if (string.IsNullOrWhiteSpace(cliente.Nombre))
                {
                    mensaje = "El nombre es requerido.";
                    return false;
                }

                if (string.IsNullOrWhiteSpace(cliente.PrimerApellido))
                {
                    mensaje = "El primer apellido es requerido.";
                    return false;
                }

                if (string.IsNullOrWhiteSpace(cliente.SegundoApellido))
                {
                    mensaje = "El segundo apellido es requerido.";
                    return false;
                }

                if (cliente.FechaNacimiento >= DateTime.Today.AddYears(-18))
                {
                    mensaje = "El cliente debe ser mayor de edad.";
                    return false;
                }

                if (datosCliente.ExisteCliente(cliente.Id))
                {
                    mensaje = "Ya existe un cliente con esa identificación.";
                    return false;
                }

                //  Insertar en base de datos
                bool resultado = datosCliente.Insertar(cliente);

                if (!resultado)
                {
                    mensaje = "No se pudo insertar el cliente.";
                    return false;
                }

                mensaje = "Cliente registrado correctamente.";
                return true;
            }
            catch (Exception ex)
            {
                mensaje = $"Error inesperado: {ex.Message}";
                return false;
            }
        }
        // Método que obtiene la lista de todos los clientes.
        // Devuelve una lista de ClienteEntidad 
        public List<ClienteEntidad> ObtenerTodos(out string mensaje)
        {
            mensaje = string.Empty;

            try
            {
                return datosCliente.ObtenerTodos();
            }
            catch (Exception ex)
            {
                mensaje = $"Error al obtener clientes: {ex.Message}";
                return new List<ClienteEntidad>();
            }
        }
        // Método que verifica si un cliente existe por su identificación.
        public bool ExisteCliente(int id)
        {
            return datosCliente.ExisteCliente(id);
        }

        // Método que valida si el cliente existe y retorna un mensaje con estado y nombre completo.
        // Se usa para autenticación o conexión desde el cliente.

        public string ValidarCliente(int idCliente)
        {
            try
            {
                var cliente = datosCliente.ValidarCliente(idCliente);

                if (cliente != null)
                {
                    return "OK|" + cliente.NombreCompleto;
                }
                else
                {
                    return "ERROR|Cliente no encontrado";
                }
            }
            catch (Exception ex)
            {
                return "ERROR|" + ex.Message;
            }
        }

    }
}

