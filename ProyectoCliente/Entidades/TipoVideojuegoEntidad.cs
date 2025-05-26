using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TipoVideojuegoEntidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        //Para mostrar en el datagridview
        public string NombreTipo => $"{Nombre}";


        //Para el comboBox
        public override string ToString()
        {
            return Nombre;
        }

    }
}
