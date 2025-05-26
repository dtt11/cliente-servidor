using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 
 * UNED I Cuatrimestre
 * Proyecto 1: Se ha solicitado el desarrollo de una aplicación de escritorio en C# 
 * para la cadena de tiendas de videojuegos 45GAMES4U, con el objetivo de gestionar 
 * y administrar el inventario de videojuegos en cada una de sus tiendas. 
 * 
 * Estudiante: Daniel Tapia Traña
 * 
 * Fecha: 23/02/25
 */
namespace Entidades
{
    public class VideojuegosXTiendaEntidad
    {
        public TiendaEntidad Tienda { get; set; }

        public VideojuegoEntidad Videojuego { get; set; }   

        public int Existencias { get; set; }






    }
}
