using System;
using System.Collections.Generic;
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
    public class ReservaBD
    {
        private readonly ConexionBD conexion;

        public ReservaBD()
        {
            conexion = new ConexionBD();
        }



        // Método que guarda una reserva en la base de datos y actualiza las existencias disponibles.
        public bool GuardarReserva(ReservaEntidad reserva, out string mensaje)
        {
            mensaje = "";

            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                SqlTransaction transaccion = conn.BeginTransaction();

                try
                {
                    // Validar que los objetos estén correctamente instanciados
                    if (reserva?.VideojuegoPorTienda?.Tienda == null || reserva?.VideojuegoPorTienda?.Videojuego == null)
                    {
                        mensaje = "La reserva no tiene los datos completos de tienda o videojuego.";
                        return false;
                    }

                    // Obtener existencias actuales
                    SqlCommand cmdExistencias = new SqlCommand(@"
                SELECT Existencias FROM VideojuegosXTienda 
                WHERE Id_Tienda = @IdTienda AND Id_Videojuego = @IdVideojuego", conn, transaccion);
                    cmdExistencias.Parameters.AddWithValue("@IdTienda", reserva.VideojuegoPorTienda.Tienda.Id);
                    cmdExistencias.Parameters.AddWithValue("@IdVideojuego", reserva.VideojuegoPorTienda.Videojuego.Id);

                    object resultado = cmdExistencias.ExecuteScalar();
                    if (resultado == null)
                    {
                        mensaje = "No se encontró inventario para ese videojuego en la tienda.";
                        transaccion.Rollback();
                        return false;
                    }

                    int existenciasActuales = Convert.ToInt32(resultado);

                    if (existenciasActuales < reserva.Cantidad)
                    {
                        mensaje = "No hay suficientes existencias para realizar la reserva.";
                        transaccion.Rollback();
                        return false;
                    }

                    // Insertar reserva
                    SqlCommand cmdInsert = new SqlCommand(@"
                INSERT INTO Reserva (Id_Videojuego, Id_Tienda, Id_Cliente, FechaReserva, Cantidad)
                VALUES (@IdVideojuego, @IdTienda, @IdCliente, @FechaReserva, @Cantidad)", conn, transaccion);
                    cmdInsert.Parameters.AddWithValue("@IdVideojuego", reserva.VideojuegoPorTienda.Videojuego.Id);
                    cmdInsert.Parameters.AddWithValue("@IdTienda", reserva.VideojuegoPorTienda.Tienda.Id);
                    cmdInsert.Parameters.AddWithValue("@IdCliente", reserva.Cliente.Id);
                    cmdInsert.Parameters.AddWithValue("@FechaReserva", reserva.FechaReserva);
                    cmdInsert.Parameters.AddWithValue("@Cantidad", reserva.Cantidad);

                    cmdInsert.ExecuteNonQuery();

                    // Actualizar existencias
                    SqlCommand cmdUpdate = new SqlCommand(@"
                UPDATE VideojuegosXTienda
                SET Existencias = Existencias - @Cantidad
                WHERE Id_Tienda = @IdTienda AND Id_Videojuego = @IdVideojuego", conn, transaccion);
                    cmdUpdate.Parameters.AddWithValue("@Cantidad", reserva.Cantidad);
                    cmdUpdate.Parameters.AddWithValue("@IdTienda", reserva.VideojuegoPorTienda.Tienda.Id);
                    cmdUpdate.Parameters.AddWithValue("@IdVideojuego", reserva.VideojuegoPorTienda.Videojuego.Id);

                    cmdUpdate.ExecuteNonQuery();

                    transaccion.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    mensaje = "Error al guardar la reserva: " + ex.Message;
                    return false;
                }
            }
        }

        // Método que obtiene todas las reservas realizadas por un cliente específico.
        public List<ReservaEntidad> ConsultarPorCliente(int idCliente)
        {
            var lista = new List<ReservaEntidad>();

            const string query = @"
        SELECT 
            r.FechaReserva, r.Cantidad,
            v.Id AS IdVideojuego, v.Nombre AS NombreVideojuego,
            t.Id AS IdTienda, t.Nombre AS NombreTienda
        FROM Reserva r
        INNER JOIN Videojuego v ON r.Id_Videojuego = v.Id
        INNER JOIN Tienda t ON r.Id_Tienda = t.Id
        WHERE r.Id_Cliente = @IdCliente";

            using (SqlConnection conn = conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@IdCliente", idCliente);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var reserva = new ReservaEntidad
                        {
                            Cliente = new ClienteEntidad { Id = idCliente },
                            FechaReserva = Convert.ToDateTime(reader["FechaReserva"]),
                            Cantidad = Convert.ToInt32(reader["Cantidad"]),
                            VideojuegoPorTienda = new VideojuegosXTiendaEntidad
                            {
                                Videojuego = new VideojuegoEntidad
                                {
                                    Id = Convert.ToInt32(reader["IdVideojuego"]),
                                    Nombre = reader["NombreVideojuego"].ToString()
                                },
                                Tienda = new TiendaEntidad
                                {
                                    Id = Convert.ToInt32(reader["IdTienda"]),
                                    Nombre = reader["NombreTienda"].ToString()
                                }
                            }
                        };

                        lista.Add(reserva);
                    }
                }
            }

            return lista;
        }


    }
}
