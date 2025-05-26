using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    public class VideojuegoBD
    {
        private readonly ConexionBD conexion;

        public VideojuegoBD()
        {
            conexion = new ConexionBD();
        }
        // Método que inserta un videojuego en la base de datos 
        public bool Insertar(VideojuegoEntidad videojuego)
        {
            const string query = @"INSERT INTO Videojuego 
                (Nombre, Id_TipoVideojuego, Desarrollador, Lanzamiento, Fisico) 
                VALUES (@Nombre, @Id_TipoVideojuego, @Desarrollador, @Lanzamiento, @Fisico);
                SELECT SCOPE_IDENTITY();";

            using (SqlConnection conn = conexion.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(query, conn))
            {
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 40).Value = videojuego.Nombre;
                comando.Parameters.Add("@Id_TipoVideojuego", SqlDbType.Int).Value = videojuego.TipoVideojuego.Id;
                comando.Parameters.Add("@Desarrollador", SqlDbType.NVarChar, 80).Value = videojuego.Desarrollador;
                comando.Parameters.Add("@Lanzamiento", SqlDbType.Int).Value = videojuego.Lanzamiento;
                comando.Parameters.Add("@Fisico", SqlDbType.Bit).Value = videojuego.Fisico;

                try
                {
                    conn.Open();
                    object result = comando.ExecuteScalar();

                    if (result == null || result == DBNull.Value)
                        throw new Exception("No se generó un ID. Revisa los datos ingresados.");

                    videojuego.Id = Convert.ToInt32(result);
                    return true;
                }
                catch (SqlException ex)
                {
                    throw new Exception("Error al insertar videojuego: " + ex.Message, ex);
                }
            }
        }
        // Método que consulta todos los videojuegos en la base de datos 
        public List<VideojuegoEntidad> ObtenerTodos()
        {
            var lista = new List<VideojuegoEntidad>();

            const string query = @"SELECT 
                v.Id, v.Nombre, v.Id_TipoVideojuego, v.Desarrollador, v.Lanzamiento, v.Fisico,
                t.Nombre AS NombreTipo, t.Descripcion AS DescripcionTipo
            FROM Videojuego v
            INNER JOIN TipoVideojuego t ON v.Id_TipoVideojuego = t.Id
            ORDER BY v.Id";

            using (SqlConnection conn = conexion.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(query, conn))
            {
                try
                {
                    conn.Open();
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var videojuego = new VideojuegoEntidad
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Nombre = reader["Nombre"].ToString(),
                                Desarrollador = reader["Desarrollador"].ToString(),
                                Lanzamiento = Convert.ToInt32(reader["Lanzamiento"]),
                                Fisico = Convert.ToBoolean(reader["Fisico"]),
                                TipoVideojuego = new TipoVideojuegoEntidad
                                {
                                    Id = Convert.ToInt32(reader["Id_TipoVideojuego"]),
                                    Nombre = reader["NombreTipo"].ToString(),
                                    Descripcion = reader["DescripcionTipo"].ToString()
                                }
                            };

                            lista.Add(videojuego);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception("Error al obtener videojuegos: " + ex.Message, ex);
                }
            }

            return lista;
        }


        //Metodo para obtener solo videojuegos fisicos y mostrarlos en el inventario
        public List<VideojuegoEntidad> ObtenerFisicos()
        {
            var lista = new List<VideojuegoEntidad>();
            const string query = @"SELECT 
                v.Id, v.Nombre, v.Id_TipoVideojuego, v.Desarrollador, v.Lanzamiento, v.Fisico,
                t.Nombre AS NombreTipo, t.Descripcion AS DescripcionTipo
            FROM Videojuego v
            INNER JOIN TipoVideojuego t ON v.Id_TipoVideojuego = t.Id
            WHERE v.Fisico = 1
            ORDER BY v.Id";

            using (SqlConnection conn = conexion.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(query, conn))
            {
                try
                {
                    conn.Open();
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var videojuego = new VideojuegoEntidad
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Nombre = reader["Nombre"].ToString(),
                                Desarrollador = reader["Desarrollador"].ToString(),
                                Lanzamiento = Convert.ToInt32(reader["Lanzamiento"]),
                                Fisico = Convert.ToBoolean(reader["Fisico"]),
                                TipoVideojuego = new TipoVideojuegoEntidad
                                {
                                    Id = Convert.ToInt32(reader["Id_TipoVideojuego"]),
                                    Nombre = reader["NombreTipo"].ToString(),
                                    Descripcion = reader["DescripcionTipo"].ToString()
                                }
                            };

                            lista.Add(videojuego);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception("Error al obtener videojuegos físicos", ex);
                }
            }

            return lista;
        }

    }
}
