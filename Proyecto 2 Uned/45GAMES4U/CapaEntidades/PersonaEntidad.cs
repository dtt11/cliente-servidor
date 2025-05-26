using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


namespace CapaEntidades
    {
        public class PersonaEntidad
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string PrimerApellido { get; set; }
            public string SegundoApellido { get; set; }
            public DateTime FechaNacimiento { get; set; }
            
            //Para mostrar en el datagridview
            public string NombreCompleto => $"{Nombre} {PrimerApellido} {SegundoApellido}";


        }
    }

