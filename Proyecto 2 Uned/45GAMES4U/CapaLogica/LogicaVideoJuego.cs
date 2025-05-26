using System;
using System.Collections.Generic;
using System.Linq;
using CapaDatos;
using CapaEntidades;
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
    public class LogicaVideojuego
    {
        private readonly VideojuegoBD datosVideojuego;
        private readonly TipoVideojuegoBD datosTipoVideojuego;

        public LogicaVideojuego()
        {
            datosVideojuego = new VideojuegoBD();
            datosTipoVideojuego = new TipoVideojuegoBD();
        }

        // Método para insertar con validación
        public bool Insertar(VideojuegoEntidad videojuego, out string mensaje)
        {
            mensaje = string.Empty;

            try
            {
                // Validación 1: Campos requeridos
                if (string.IsNullOrWhiteSpace(videojuego.Nombre))
                {
                    mensaje = "El nombre del videojuego es requerido";
                    return false;
                }

                // Validación 2: Longitud máxima
                if (videojuego.Nombre.Length > 40)
                {
                    mensaje = "El nombre no puede exceder 40 caracteres";
                    return false;
                }

                if (videojuego.TipoVideojuego == null || videojuego.TipoVideojuego.Id <= 0)
                {
                    mensaje = "Debe seleccionar un tipo de videojuego válido.";
                    return false;
                }

                if (string.IsNullOrWhiteSpace(videojuego.Desarrollador))
                {
                    mensaje = "El desarrollador es requerido";
                    return false;
                }


                if (videojuego.Desarrollador.Length > 80)
                {
                    mensaje = "El nombre del desarrollador no puede exceder 80 caracteres";
                    return false;
                }

              
                bool resultado = datosVideojuego.Insertar(videojuego);

                if (!resultado)
                {
                    mensaje = "No se pudo insertar el videojuego.";
                    return false;
                }



                mensaje = "Videojuego registrado correctamente";
                return true;
            }
            catch (Exception ex)
            {
                mensaje = $"Error inesperado: {ex.Message}";
                return false;
            }
        }

        // Método para obtener todos los videojuegos registrados
        public List<VideojuegoEntidad> ObtenerTodos(out string mensaje)
        {
            mensaje = string.Empty;

            try
            {
                return datosVideojuego.ObtenerTodos();
            }
            catch (Exception ex)
            {
                mensaje = $"Error al obtener los videojuegos: {ex.Message}";
                return new List<VideojuegoEntidad>();
            }
        }
        // Método para obtener todos los videojuegos fisicos registrados

        public List<VideojuegoEntidad> ObtenerVideojuegosFisicos(out string mensaje)
        {
            mensaje = string.Empty;

            try
            {
                return datosVideojuego.ObtenerFisicos();
            }
            catch (Exception ex)
            {
                mensaje = $"Error al obtener videojuegos físicos: {ex.Message}";
                return new List<VideojuegoEntidad>();
            }
        }


    }
}
