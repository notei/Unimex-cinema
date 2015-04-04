using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace unimex.lenguajesv.cine.DTO
{
    class PreciosDTO
    {
        private int id_precios;
        private String nombre;
        private String descripcion;
        private int precio;


        public int id_Precios
        {
            get { return id_precios; }
            set { id_precios = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value;}
        }

        public int Precios
        {
            get { return precio; }
            set { precio = value;}
        }
    }
}
