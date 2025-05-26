using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;//referenciar la cadena de conexion que esta en el archivo app.config
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

/*Codigo tomado de ✅ crud c# sql server - (Administrador de empleados en Windows Form).
   (s. f.). YouTube. https://www.youtube.com/playlist?list=PLSuKjujFoGJ3JzIbDs4hzVq8pfthRgAU-
  */

namespace CapaDatos
{
    internal class ConexionBD
    {
  
        private readonly string cadenaConexion;

        public ConexionBD()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            // Asigna la cadena de conexión definida en el archivo de configuración.
        }

        // Método que devuelve una nueva conexión SQL utilizando la cadena de conexión configurada.
        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
            // Retorna una instancia de SqlConnection con la cadena de conexión.
        }

    }
}
