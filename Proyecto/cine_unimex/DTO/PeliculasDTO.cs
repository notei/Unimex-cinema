using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace unimex.lenguajesv.cine.DTO
{
    class PeliculasDTO
    {
        private int id_pelicula;
        private String pelicula;
        private int id_clasificacion;
        private int duracion_min;
        private String sinopsis;
        private String idioma;
        private String sonido;
        private int id_nacionalidad;
        private int id_genero;
        private bool estreno;

        public int id_Pelicula
        {
            
            get { return id_pelicula; }
             
            set { id_pelicula = value; }
        }

        public String Pelicula
        {
            get { return pelicula; }
             
            set { pelicula = value; }
        }
        public int id_Clasificacion
        {
            get { return id_clasificacion; }
             
            set { id_clasificacion = value; }
        }

        public int Duracion_min
        {
            get { return duracion_min; }
             
            set { duracion_min = value; }
        }
        public String Sinopsis
        {
            get { return sinopsis; }
             
            set { sinopsis = value; }
        }
        public String Idioma
        {
            get { return idioma; }
             
            set { idioma = value; }
        }
        public String Sonido
        {
            get { return sonido; }
             
            set { sonido = value; }
        }
        public int id_Nacionalidad
        {
            get { return id_nacionalidad; }
             
            set { id_nacionalidad = value; }
        }
        public int id_Genero
        {
            get { return id_genero; }
             
            set { id_genero = value; }
        }
        public bool Estreno
        {
            get { return estreno; }
             
            set { estreno = value; }
        }
        }
    }

