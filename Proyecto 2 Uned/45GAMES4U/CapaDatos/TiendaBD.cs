
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
    public class TiendaBD
    {
        private readonly ConexionBD conexion;
        public TiendaBD()
        {
            conexion = new ConexionBD();
        }

        // Método que inserta una tienda en la base de datos 
        public bool Insertar(TiendaEntidad tienda)
        {
            const string query = @"INSERT INTO Tienda 
                (Nombre, Id_Administrador, Direccion, Telefono, Activa)
                VALUES (@Nombre, @Id_Administrador, @Direccion, @Telefono, @Activa);
                SELECT SCOPE_IDENTITY();";


            using (SqlConnection conn = conexion.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(query, conn))
            {
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 60).Value = tienda.Nombre;
                comando.Parameters.Add("@Id_Administrador", SqlDbType.Int).Value = tienda.Administrador.Id;
                comando.Parameters.Add("@Direccion", SqlDbType.NVarChar, 100).Value = tienda.Direccion;
                comando.Parameters.Add("@Telefono", SqlDbType.NVarChar, 20).Value = tienda.Telefono;
                comando.Parameters.Add("@Activa", SqlDbType.Bit).Value = tienda.Activa;

                try
                {
                    conn.Open();
                    object resultado = comando.ExecuteScalar();

                    if (resultado == null || resultado == DBNull.Value)
                        throw new Exception("No se generó un ID. Verificá si la tienda ya existe.");

                    tienda.Id = Convert.ToInt32(resultado);
                    return true;
                }
                catch (SqlException ex)
                {
                    throw new Exception("Error al insertar tienda: " + ex.Message, ex);
                }
            }
        }

        // Método que consulta una tienda en la base de datos 
        public List<TiendaEntidad> ObtenerTodos()
        {
            List<TiendaEntidad> lista = new List<TiendaEntidad>();

            const string query = @"SELECT
        t.Id, t.Nombre, t.Direccion, t.Telefono, t.Activa,
        a.Identificacion AS IdAdministrador,
        a.Nombre AS NombreAdmin,
        a.PrimerApellido, a.SegundoApellido,
        a.FechaContratacion
    FROM Tienda t
    INNER JOIN Administrador a ON t.Id_Administrador = a.Identificacion";

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
                            var tienda = new TiendaEntidad
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Nombre = reader["Nombre"].ToString(),
                                Direccion = reader["Direccion"].ToString(),
                                Telefono = reader["Telefono"].ToString(),
                                Activa = Convert.ToBoolean(reader["Activa"]),
                                Administrador = new AdministradorEntidad
                                {
                                    Id = Convert.ToInt32(reader["IdAdministrador"]),
                                    Nombre = reader["NombreAdmin"].ToString(),
                                    PrimerApellido = reader["PrimerApellido"].ToString(),
                                    SegundoApellido = reader["SegundoApellido"].ToString(),
                                    FechaContratacion = Convert.ToDateTime(reader["FechaContratacion"])
                                }
                            };

                            lista.Add(tienda);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception("Error al obtener tiendas: " + ex.Message, ex);
                }
            }

            return lista;
        }


    }


}