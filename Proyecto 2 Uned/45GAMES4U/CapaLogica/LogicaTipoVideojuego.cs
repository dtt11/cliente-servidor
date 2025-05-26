using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    public class LogicaTipoVideojuego
    {
        private readonly TipoVideojuegoBD datosTipoVideojuego;

        public LogicaTipoVideojuego()
        {
            datosTipoVideojuego = new TipoVideojuegoBD();
        }

        // Método para insertar con validación
        public bool Insertar(TipoVideojuegoEntidad tipo, out string mensaje)
        {
            mensaje = string.Empty;

            try
            {
                // Validación 1: Campos requeridos
                if (string.IsNullOrWhiteSpace(tipo.Nombre))
                {
                    mensaje = "El nombre del tipo de videojuego es requerido";
                    return false;
                }

                // Validación 2: Longitud máxima
                if (tipo.Nombre.Length > 40)
                {
                    mensaje = "El nombre no puede exceder 40 caracteres";
                    return false;
                }

                // Validación 3: Descripción no vacía
                if (string.IsNullOrWhiteSpace(tipo.Descripcion))
                {
                    mensaje = "La descripción es requerida";
                    return false;
                }

                // Insertar en la base de datos
                bool resultado = datosTipoVideojuego.Insertar(tipo);

                if (!resultado)
                {
                    mensaje = "Error al insertar en la base de datos";
                    return false;
                }

                mensaje = "Tipo de videojuego registrado correctamente";
                return true;
            }
            catch (Exception ex)
            {
                mensaje = $"Error inesperado: {ex.Message}";
                return false;
            }
        }

        // Método para obtener todos los tipos
       
        public List<TipoVideojuegoEntidad> ObtenerTodos(out string mensaje)
        {
            mensaje = string.Empty;

            try
            {
                return datosTipoVideojuego.ObtenerTodos();
            }
            catch (Exception ex)
            {
                mensaje = $"Error al obtener los tipos: {ex.Message}";
                return new List<TipoVideojuegoEntidad>();
            }
        }

    }
}
