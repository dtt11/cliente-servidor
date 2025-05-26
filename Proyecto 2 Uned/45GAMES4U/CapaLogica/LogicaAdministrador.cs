using System;
using System.Collections.Generic;
using System.Linq;
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
    public class LogicaAdministrador
    {
        // Instancia de la clase de acceso a datos para administradores
        private readonly AdministradorBD datosAdministrador;

        // Constructor: inicializa la lógica creando una instancia de la capa de datos
        public LogicaAdministrador()
        {
            datosAdministrador = new AdministradorBD();
        }

        // Método para insertar un nuevo administrador, incluyendo validaciones de negocio
        public bool Insertar(AdministradorEntidad administrador, out string mensaje)
        {
            mensaje = string.Empty;

            // Validación: ID debe ser mayor que cero
            if (administrador.Id <= 0)
            {
                mensaje = "La identificación es requerida y debe ser mayor que cero.";
                return false;
            }

            // Validación: el nombre no puede estar vacío
            if (string.IsNullOrWhiteSpace(administrador.Nombre))
            {
                mensaje = "El nombre es requerido.";
                return false;
            }

            // Validación: el primer apellido no puede estar vacío
            if (string.IsNullOrWhiteSpace(administrador.PrimerApellido))
            {
                mensaje = "El primer apellido es requerido.";
                return false;
            }

            // Validación: el segundo apellido no puede estar vacío
            if (string.IsNullOrWhiteSpace(administrador.SegundoApellido))
            {
                mensaje = "El segundo apellido es requerido.";
                return false;
            }

            // Validación: debe ser mayor de edad (18 años)
            if (administrador.FechaNacimiento >= DateTime.Today.AddYears(-18))
            {
                mensaje = "El administrador debe ser mayor de edad.";
                return false;
            }

            // Validación: la fecha de contratación no puede ser futura
            if (administrador.FechaContratacion > DateTime.Today)
            {
                mensaje = "La fecha de contratación no puede ser futura.";
                return false;
            }

            // Validación: la identificación debe ser única
            if (datosAdministrador.ExisteAdministrador(administrador.Id))
            {
                mensaje = "Ya existe un administrador con esa identificación.";
                return false;
            }

            // Si todas las validaciones pasan, intenta insertar el administrador
            try
            {
                bool resultado = datosAdministrador.Insertar(administrador);
                mensaje = resultado ? "Administrador registrado correctamente." : "No se pudo registrar el administrador.";
                return resultado;
            }
            catch (Exception ex)
            {
                // Manejo de errores inesperados
                mensaje = $"Error inesperado: {ex.Message}";
                return false;
            }
        }

        // Método para obtener todos los administradores registrados
        public List<AdministradorEntidad> ObtenerTodos(out string mensaje)
        {
            mensaje = string.Empty;

            try
            {
                return datosAdministrador.ObtenerTodos();
            }
            catch (Exception ex)
            {
                // Si hay un error, se retorna lista vacía y se asigna el mensaje
                mensaje = $"Error al obtener administradores: {ex.Message}";
                return new List<AdministradorEntidad>();
            }
        }

    }
}
