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
    public class LogicaTienda
    {
        private readonly TiendaBD datosTienda;

        public LogicaTienda()
        {
            datosTienda = new TiendaBD();
        }
        // Método para insertar una nueva tienda con validaciones de negocio
        public bool Insertar(TiendaEntidad tienda, out string mensaje)
        {
            mensaje = string.Empty;

            if (string.IsNullOrWhiteSpace(tienda.Nombre))
            {
                mensaje = "El nombre de la tienda es requerido.";
                return false;
            }

            if (tienda.Administrador == null || tienda.Administrador.Id <= 0)
            {
                mensaje = "Debe seleccionar un administrador válido.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(tienda.Direccion))
            {
                mensaje = "La dirección es requerida.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(tienda.Telefono))
            {
                mensaje = "El teléfono es requerido.";
                return false;
            }

            try
            {
                bool resultado = datosTienda.Insertar(tienda);
                mensaje = resultado ? "Tienda registrada correctamente." : "No se pudo registrar la tienda.";
                return resultado;
            }
            catch (Exception ex)
            {
                mensaje = $"Error inesperado: {ex.Message}";
                return false;
            }
        }

        // Método para obtener todas las tiendas registradas
        public List<TiendaEntidad> ObtenerTodos(out string mensaje)
        {
            mensaje = string.Empty;

            try
            {
                return datosTienda.ObtenerTodos();
            }
            catch (Exception ex)
            {
                mensaje = $"Error al obtener tiendas: {ex.Message}";
                return new List<TiendaEntidad>();
            }
        }
    }
}

