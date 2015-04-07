using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace unimex.lenguajesv.cine.DTO
{
    class SalasDTO
    {
        private int id_sala;
        private int id_complejo;
        private String nombre_sala;
        private int capacidad;
        private Boolean butacas_numeradas;
        private int id_tipo_sonido;
        private int id_tipo_proyeccion;

        public int Id_Sala
        {
            get { return id_sala; }
            set{id_sala = value;}
        

        }
        public int Id_Complejo 
        {
            get { return id_complejo; }
            set { id_complejo = value; }

        }
        public String Nombre_Sala 
        {
            get { return nombre_sala; }
            set { nombre_sala = value; }

        
        }
        public int Capacidad 
        {
            get { return capacidad; }
            set { capacidad = value; }

        }
        public Boolean Butacas_Numeradas 
        {
            get { return butacas_numeradas; }
            set{butacas_numeradas = value; }
        }
        public int Id_Tipo_Sonido 
        {
            get { return id_tipo_sonido; }
            set { id_tipo_sonido = value; }

        }
        public int Id_Tipo_Proyeccion
        {
            get { return id_tipo_proyeccion; }
            set { id_tipo_proyeccion = value; }
        
    }
        
    }
}
