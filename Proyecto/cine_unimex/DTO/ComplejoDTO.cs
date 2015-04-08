using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace unimex.lenguajesv.cine.DTO
{
    class ComplejoDTO
    {
        private int id_complejo;
        private String nombre;
        private String direccion;
        private String telefono;
        private Boolean habilitado;

        public int id_Complejos
        {
            get { return id_complejo; }
            set { id_complejo = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public String Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public Boolean Habilitado
        {
            get { return habilitado; }
            set { habilitado = value; }
        }     
    }
}
