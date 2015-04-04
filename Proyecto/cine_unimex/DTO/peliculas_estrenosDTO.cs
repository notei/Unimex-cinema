using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using unimex.lenguajesv.cine.DAO;
using unimex.lenguajesv.cine.DTO;

namespace unimex.lenguajesv.cine.DTO
{
    class peliculas_estrenosDTO
    {
        private int id_estreno;
        private String fecha_estreno;
        private String pelicula;
        private bool habilitado;

        public int Id_estreno
        {
            get { return id_estreno; }
            set { id_estreno = value;}

        }
        public String Fecha_estreno
        {
            get { return fecha_estreno; }
            set { fecha_estreno = value; }
        }
        public String Pelicula
        {
            get { return pelicula; }
            set { pelicula = value; }
        }
        public bool Habilitado
        {
            get{return habilitado;}
            set{habilitado = value;}

        }


        }

    }

   