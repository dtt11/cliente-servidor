using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class ReservaEntidad
    {
        public int Id { get; set; } // Se genera en base de datos
        public VideojuegosXTiendaEntidad VideojuegoPorTienda { get; set; }
        public ClienteEntidad Cliente { get; set; }
        public DateTime FechaReserva { get; set; }
        public int Cantidad { get; set; }

    }
}
