using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace unimex.lenguajesv.cine.DTO
{
    class ProyeccionesDTO
    {
        private int id_proyeccion ;
        private int id_sala;
        private int id_pelicula;
        private String fecha;
        private DateTime fechasdt;
        private int id_Complejo;
        public int idproyeccion
        {
            //Obtener
            get { return id_proyeccion; }
            //poner o dar 
            set { id_proyeccion = value; } 
        }
        
        public int idsala
        {
            get { return id_sala; }
            set { id_sala = value; }

        }

        public int idpelicula
        {
            get { return id_pelicula; }
            set { id_pelicula = value; }
        }
        public String fechas
        {
            get { return fecha; }
            set {fecha = value;}
        }

        public DateTime fechasDT
        {
            get { return fechasdt; }
            set { fechasdt = value; }
        }
        public int idcomplejo
        {
            get { return id_Complejo; }
            set { id_Complejo = value; }
        }
    }
    }

