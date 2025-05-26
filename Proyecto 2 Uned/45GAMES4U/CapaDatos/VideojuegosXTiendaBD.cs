using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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



/*Codigo tomado de ✅ crud c# sql server - (Administrador de empleados en Windows Form).
        (s. f.). YouTube. https://www.youtube.com/playlist?list=PLSuKjujFoGJ3JzIbDs4hzVq8pfthRgAU-

RJ Code Advance. (2018, 19 abril). CRUD con C#, WinForm, SQL Server, POO y Arquitectura en Capas- Nivel Básico
[Vídeo]. YouTube. https://www.youtube.com/watch?v=_H8vswpMSOw
 */
namespace CapaDatos
{
    public class VideojuegosXTiendaBD
    {
        private readonly ConexionBD conexion;

        public VideojuegosXTiendaBD()
        {
            conexion = new ConexionBD();
        }

        // Método que inserta un nuevo registro de inventario en la tabla VideojuegosXTienda.
        public bool Insertar(VideojuegosXTiendaEntidad inventario)
        {
            const string query = @"INSERT INTO VideojuegosXTienda 
                (Id_Tienda, Id_Videojuego, Existencias) 
                VALUES (@Id_Tienda, @Id_Videojuego, @Existencias);";

            using (SqlConnection conn = conexion.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(query, conn))
            {
                comando.Parameters.Add("@Id_Tienda", SqlDbType.Int).Value = inventario.Tienda.Id;
                comando.Parameters.Add("@Id_Videojuego", SqlDbType.Int).Value = inventario.Videojuego.Id;
                comando.Parameters.Add("@Existencias", SqlDbType.Int).Value = inventario.Existencias;

                try
                {
                    conn.Open();
                    int filas = comando.ExecuteNonQuery();
                    return filas > 0;
                }
                catch (SqlException ex)
                {
                    throw new Exception("Error al insertar en VideojuegosXTienda" + ex.Message);
                }
            }
        }

        // Método que obtiene todos los registros de videojuegos por tienda.
        public List<VideojuegosXTiendaEntidad> ObtenerTodos()
        {
            var lista = new List<VideojuegosXTiendaEntidad>();

            const string query = @"SELECT 
        vxt.Id_Tienda, vxt.Id_Videojuego, vxt.Existencias,
        t.Nombre AS NombreTienda, t.Direccion,
        v.Nombre AS NombreVideojuego,
        tv.Nombre AS NombreTipo
    FROM VideojuegosXTienda vxt
    INNER JOIN Tienda t ON vxt.Id_Tienda = t.Id
    INNER JOIN Videojuego v ON vxt.Id_Videojuego = v.Id
    INNER JOIN TipoVideojuego tv ON v.Id_TipoVideojuego = tv.Id";

            using (SqlConnection conn = conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var inventario = new VideojuegosXTiendaEntidad
                            {
                                Tienda = new TiendaEntidad
                                {
                                    Id = Convert.ToInt32(reader["Id_Tienda"]),
                                    Nombre = reader["NombreTienda"].ToString(),
                                    Direccion = reader["Direccion"].ToString()
                                },
                                Videojuego = new VideojuegoEntidad
                                {
                                    Id = Convert.ToInt32(reader["Id_Videojuego"]),
                                    Nombre = reader["NombreVideojuego"].ToString(),
                                    TipoVideojuego = new TipoVideojuegoEntidad
                                    {
                                        Nombre = reader["NombreTipo"].ToString()
                                    }
                                },
                                Existencias = Convert.ToInt32(reader["Existencias"])
                            };

                            lista.Add(inventario);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception("Error al obtener VideojuegosXTienda", ex);
                }
            }

            return lista;
        }

        // Método que obtiene todos los videojuegos disponibles en una tienda específica.
        public List<VideojuegosXTiendaEntidad> ObtenerPorTienda(int idTienda)
        {
            var lista = new List<VideojuegosXTiendaEntidad>();

            const string query = @"SELECT 
        vxt.Id_Tienda, vxt.Id_Videojuego, vxt.Existencias,
        t.Nombre AS NombreTienda, t.Direccion,
        v.Nombre AS NombreVideojuego,
        tv.Nombre AS NombreTipo
    FROM VideojuegosXTienda vxt
    INNER JOIN Tienda t ON vxt.Id_Tienda = t.Id
    INNER JOIN Videojuego v ON vxt.Id_Videojuego = v.Id
    INNER JOIN TipoVideojuego tv ON v.Id_TipoVideojuego = tv.Id
    WHERE vxt.Id_Tienda = @IdTienda";

            using (SqlConnection conn = conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@IdTienda", idTienda);

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var inventario = new VideojuegosXTiendaEntidad
                            {
                                Tienda = new TiendaEntidad
                                {
                                    Id = Convert.ToInt32(reader["Id_Tienda"]),
                                    Nombre = reader["NombreTienda"].ToString(),
                                    Direccion = reader["Direccion"].ToString()
                                },
                                Videojuego = new VideojuegoEntidad
                                {
                                    Id = Convert.ToInt32(reader["Id_Videojuego"]),
                                    Nombre = reader["NombreVideojuego"].ToString(),
                                    TipoVideojuego = new TipoVideojuegoEntidad
                                    {
                                        Nombre = reader["NombreTipo"].ToString()
                                    }
                                },
                                Existencias = Convert.ToInt32(reader["Existencias"])
                            };

                            lista.Add(inventario);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception("Error al obtener inventario por tienda", ex);
                }
            }

            return lista;
        }


        // Método que verifica si ya existe un registro en VideojuegosXTienda
        // para una combinación específica de tienda y videojuego.
        public bool ExisteRelacion(int idTienda, int idVideojuego)
        {
            const string query = "SELECT 1 FROM VideojuegosXTienda WHERE Id_Tienda = @IdTienda AND Id_Videojuego = @IdVideojuego";

            using (SqlConnection conn = conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.Add("@IdTienda", SqlDbType.Int).Value = idTienda;
                cmd.Parameters.Add("@IdVideojuego", SqlDbType.Int).Value = idVideojuego;

                conn.Open();
                return cmd.ExecuteScalar() != null;
            }
        }

    }
}
