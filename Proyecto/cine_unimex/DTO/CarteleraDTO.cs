using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace unimex.lenguajesv.cine.DTO
{
    class CarteleraDTO
    {
        private String pelicula;
        private String nombre_clasificacion;
        private int duracion_min;
        private String sinopsis;
        private String idioma;
        private String nacionalidad;
        private String genero;
        private Boolean estreno;

        public String Pelicula
        {
            get { return pelicula; }
            set { pelicula = value; }

        }
        public String NombreClasificacion
        {
            get { return nombre_clasificacion; }
            set { nombre_clasificacion = value; }

        }
        public int DuracionMin
        {
            get { return duracion_min; }
            set { duracion_min = value; }

        }
        public String Sinposis
        {
            get { return sinopsis; }
            set { sinopsis = value; }

        }
        public String Idioma
        {
            get { return idioma; }
            set { idioma = value; }

        }
        
        public String Nacionalidad
        {
            get { return nacionalidad; }
            set { nacionalidad = value; }

        }
        public String Genero
        {
            get { return genero; }
            set { genero = value; }

        }
        public Boolean Estreno
        {
            get { return estreno; }
            set { estreno = value; }

        }
    }
}
