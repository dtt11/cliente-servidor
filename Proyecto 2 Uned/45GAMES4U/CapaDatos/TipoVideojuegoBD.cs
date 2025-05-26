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
    public class TipoVideojuegoBD
    {
        private readonly ConexionBD conexion;

        public TipoVideojuegoBD()
        {
            conexion = new ConexionBD();
        }
        // Método que inserta un tipo de videojuego en la base de datos 
        public bool Insertar(TipoVideojuegoEntidad tipo)
        {
            const string query = @"INSERT INTO TipoVideojuego (Nombre, Descripcion) 
                                 VALUES (@Nombre, @Descripcion);
                                 SELECT SCOPE_IDENTITY();";

            using (SqlConnection conn = conexion.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(query, conn))
            {
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 40).Value = tipo.Nombre;
                comando.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 80).Value = tipo.Descripcion;

                try
                {
                    conn.Open();
                    // Ejecuta y recupera el ID generado (convertido directamente a int)
                    int idGenerado = Convert.ToInt32(comando.ExecuteScalar());
                    tipo.Id = idGenerado; // Asigna el ID generado a la entidad
                    return idGenerado > 0;
                }
                catch (SqlException ex)
                {
                    throw new Exception("Error al insertar tipo de videojuego", ex);
                }
            }
        }
        // Método que obtiene todos los tipos de videojuegos registrados en la base de datos 
        public List<TipoVideojuegoEntidad> ObtenerTodos()
        {
            List<TipoVideojuegoEntidad> lista = new List<TipoVideojuegoEntidad>();
            const string query = @"SELECT Id, Nombre, Descripcion 
                                 FROM TipoVideojuego 
                                 ORDER BY Id";

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
                            lista.Add(new TipoVideojuegoEntidad
                            {
                                Id = Convert.ToInt32(reader["Id"]), 
                                Nombre = reader["Nombre"].ToString(),
                                Descripcion = reader["Descripcion"].ToString()
                            });
                        }
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception("Error al obtener tipos de videojuegos", ex);
                }
            }

            return lista;
        }
    }
}