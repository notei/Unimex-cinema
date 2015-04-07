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
        private String sala;
        private String horario;
        private int id_complejo;
        

        public String nombreComplejo
        {
            get { return nombre; }
            set { nombre = value; }

        }

        public String Pelicula
        {
            get { return pelicula; }
            set { pelicula = value; }
        }

        public String Sala
        {
            get { return sala; }
            set { sala = value; }
        }


        public String Horario
        {
            get { return horario; }
            set { horario = value; }
        }


        public String Nombre
        
        {
            get { return nombre; }
            set { nombre = value;}
            }
        public int Id_Complejo
        
        {
            get { return id_complejo; }
            set { id_complejo = value;}
            
        }
    }
}

