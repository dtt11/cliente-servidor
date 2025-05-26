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
    public class AdministradorBD
    {
        // Instancia de la clase de conexión a la base de datos
        private readonly ConexionBD conexion;

        // Constructor: inicializa la conexión
        public AdministradorBD()
        {
            conexion = new ConexionBD();
        }

        // Método que inserta un nuevo administrador en la base de datos
        public bool Insertar(AdministradorEntidad administrador)
        {
            const string query = @"INSERT INTO Administrador 
                (Identificacion,Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, FechaContratacion) 
                VALUES (@Identificacion,@Nombre, @PrimerApellido, @SegundoApellido, @FechaNacimiento, @FechaContratacion);
                SELECT SCOPE_IDENTITY();";

            using (SqlConnection conn = conexion.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(query, conn))
            {
                comando.Parameters.Add("@Identificacion", SqlDbType.Int).Value = administrador.Id;
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 40).Value = administrador.Nombre;
                comando.Parameters.Add("@PrimerApellido", SqlDbType.NVarChar, 40).Value = administrador.PrimerApellido;
                comando.Parameters.Add("@SegundoApellido", SqlDbType.NVarChar, 40).Value = administrador.SegundoApellido;
                comando.Parameters.Add("@FechaNacimiento", SqlDbType.DateTime2).Value = administrador.FechaNacimiento.Date;
                comando.Parameters.Add("@FechaContratacion", SqlDbType.DateTime2).Value = administrador.FechaContratacion.Date;

                try
                {
                    conn.Open();
                    int id = Convert.ToInt32(comando.ExecuteNonQuery());
                    administrador.Id = id;
                    return id > 0;
                }
                catch (SqlException ex)
                {
                    throw new Exception("Error al insertar en base de datos", ex);
                }
            }
        }


        // Método que obtiene todos los administradores de la base de datos
        public List<AdministradorEntidad> ObtenerTodos()
        {
            var lista = new List<AdministradorEntidad>();
            const string query = "SELECT * FROM Administrador";

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
                            lista.Add(new AdministradorEntidad
                            {
                                Id = Convert.ToInt32(reader["Identificacion"]),
                                Nombre = reader["Nombre"].ToString(),
                                PrimerApellido = reader["PrimerApellido"].ToString(),
                                SegundoApellido = reader["SegundoApellido"].ToString(),
                                FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]),
                                FechaContratacion = Convert.ToDateTime(reader["FechaContratacion"])
                            });
                        }
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception("Error al obtener registros", ex);
                }
            }

            return lista;
        }

        // Método que verifica si existe un administrador con el ID especificado
        public bool ExisteAdministrador(int id)
        {
            const string query = "SELECT 1 FROM Administrador WHERE Identificacion = @id";
            using (var conn = conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                conn.Open();
                return cmd.ExecuteScalar() != null;
            }
        }


    }
}