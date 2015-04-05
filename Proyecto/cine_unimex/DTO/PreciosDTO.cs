using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace unimex.lenguajesv.cine.DTO
{
    class PreciosDTO
    {
        private int id_precio;
        private String nombre;
        private String descripcion;
        private float precio;


        public int id_Precios
        {
            get { return id_precio; }
            set { id_precio = value; }
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

        public float Precios
        {
            get { return precio; }
            set { precio = value;}
        }       
    }
}
