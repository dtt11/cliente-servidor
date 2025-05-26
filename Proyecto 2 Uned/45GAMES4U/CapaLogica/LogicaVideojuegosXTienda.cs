using System;
using System.Collections.Generic;
using CapaEntidades;
using CapaDatos;
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
    public class LogicaVideojuegosXTienda
    {
        private readonly VideojuegosXTiendaBD datosVXT;

        public LogicaVideojuegosXTienda()
        {
            datosVXT = new VideojuegosXTiendaBD();
        }
        // Método para insertar una nueva relación Videojuego-Tienda
        public bool Insertar(VideojuegosXTiendaEntidad entidad, out string mensaje)
        {
            mensaje = string.Empty;

            try
            {
                // Validación duplicado mínima desde BD
                if (datosVXT.ExisteRelacion(entidad.Tienda.Id, entidad.Videojuego.Id))
                {
                    mensaje = "Este videojuego ya está asignado a esta tienda.";
                    return false;
                }

                bool resultado = datosVXT.Insertar(entidad);

                if (!resultado)
                {
                    mensaje = "No se pudo registrar la relación.";
                    return false;
                }

                mensaje = "Videojuego asignado a tienda correctamente.";
                return true;
            }
            catch (Exception ex)
            {
                mensaje = $"Error inesperado: {ex.Message}";
                return false;
            }
        }
        // Método para obtener todas las relaciones Videojuego-Tienda registradas
        public List<VideojuegosXTiendaEntidad> ObtenerTodos(out string mensaje)
        {
            mensaje = string.Empty;

            try
            {
                return datosVXT.ObtenerTodos();
            }
            catch (Exception ex)
            {
                mensaje = $"Error al obtener datos: {ex.Message}";
                return new List<VideojuegosXTiendaEntidad>();
            }
        }

        // Método para obtener las relaciones específicas de una tienda
        public List<VideojuegosXTiendaEntidad> ObtenerPorTienda(int idTienda, out string mensaje)
        {
            mensaje = string.Empty;

            try
            {
                return datosVXT.ObtenerPorTienda(idTienda);
            }
            catch (Exception ex)
            {
                mensaje = $"Error al obtener el inventario: {ex.Message}";
                return new List<VideojuegosXTiendaEntidad>();
            }
        }



    }
}

