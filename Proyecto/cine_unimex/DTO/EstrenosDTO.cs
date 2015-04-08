using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace unimex.lenguajesv.cine.DTO
{
    class EstrenosDTO
    {
        private int id_estreno;
            private int id_pelicula;
            private DateTime fecha_estreno1;
            private String fecha_estreno;
            private bool habilitado;

            public int Id_estrenos
            {
                get { return id_estreno; }
                set { id_estreno = value; }
            }

        public int Id_pelicula 
        
        {
            get { return id_pelicula; }
            set { id_pelicula = value; }
        }

        public DateTime Fecha_estreno1
        {
            get { return fecha_estreno1; }
            set { fecha_estreno1 = value; }
        }

        public String Fecha_estreno
        {
            get { return fecha_estreno; }
            set { fecha_estreno = value; }
        }

        public bool Habilitado
        {
            get { return habilitado; }
            set { habilitado = value; }
        } 
        
    }
}
