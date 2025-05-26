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
    public class ClienteBD
    {
        private readonly ConexionBD conexion;

        public ClienteBD()
        {
            conexion = new ConexionBD();
        }

        // Método que inserta un nuevo cliente en la base de datos.
        public bool Insertar(ClienteEntidad cliente)
        {
            const string query = @"INSERT INTO Cliente 
                (Identificacion, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, JugadorEnLinea) 
                VALUES (@Identificacion, @Nombre, @PrimerApellido, @SegundoApellido, @FechaNacimiento, @JugadorEnLinea);";

            using (SqlConnection conn = conexion.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(query, conn))
            {
                comando.Parameters.Add("@Identificacion", SqlDbType.Int).Value = cliente.Id;
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 40).Value = cliente.Nombre;
                comando.Parameters.Add("@PrimerApellido", SqlDbType.NVarChar, 40).Value = cliente.PrimerApellido;
                comando.Parameters.Add("@SegundoApellido", SqlDbType.NVarChar, 40).Value = cliente.SegundoApellido;
                comando.Parameters.Add("@FechaNacimiento", SqlDbType.DateTime2).Value = cliente.FechaNacimiento.Date;
                comando.Parameters.Add("@JugadorEnLinea", SqlDbType.Bit).Value = cliente.JugadorEnLinea;

                try
                {
                    conn.Open();
                    int filasAfectadas = comando.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
                catch (SqlException ex)
                {
                    throw new Exception("Error al insertar cliente en la base de datos", ex);
                }
            }
        }

        // Método que obtiene todos los clientes registrados en la base de datos
        public List<ClienteEntidad> ObtenerTodos()
        {
            var lista = new List<ClienteEntidad>();
            const string query = "SELECT * FROM Cliente";

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
                            lista.Add(new ClienteEntidad
                            {
                                Id = Convert.ToInt32(reader["Identificacion"]),
                                Nombre = reader["Nombre"].ToString(),
                                PrimerApellido = reader["PrimerApellido"].ToString(),
                                SegundoApellido = reader["SegundoApellido"].ToString(),
                                FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]),
                                JugadorEnLinea = Convert.ToBoolean(reader["JugadorEnLinea"])
                            });
                        }
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception("Error al obtener clientes", ex);
                }
            }

            return lista;
        }



        // Método que verifica si un cliente existe en la base de datos según su ID.
        public bool ExisteCliente(int id)
        {
            const string query = "SELECT 1 FROM Cliente WHERE Identificacion = @id";
            using (var conn = conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                conn.Open();
                return cmd.ExecuteScalar() != null;
            }
        }
        // Método que valida un cliente por ID y retorna sus nombres y apellidos.
        public ClienteEntidad ValidarCliente(int id)
        {
            const string query = @"SELECT Nombre, PrimerApellido, SegundoApellido FROM Cliente WHERE Identificacion = @id";
            // Ejecuta una consulta SELECT con parámetro y construye el objeto ClienteEntidad.
            using (SqlConnection conn = conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new ClienteEntidad
                        {
                            Id = id,
                            Nombre = reader.GetString(0),
                            PrimerApellido = reader.GetString(1),
                            SegundoApellido = reader.GetString(2)
                        };
                    }
                }
            }

            return null; // No se encontró el cliente
        }



    }
}
