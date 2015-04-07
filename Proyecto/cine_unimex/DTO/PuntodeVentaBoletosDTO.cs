using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace unimex.lenguajesv.cine.DTO
{
    class PuntodeVentaBoletosDTO
    {
        private String nombre;
        private String pelicula;


        public String nombreComplejo
        {
            get { return nombre;}
            set { nombre = value;}

        }

        public String Pelicula
       
        {
            get { return pelicula; }
            set { pelicula = value; }
        }

        public String Sala
       
        {
            get { return Sala; }
            set { Sala = value; }
        }

    }
}
