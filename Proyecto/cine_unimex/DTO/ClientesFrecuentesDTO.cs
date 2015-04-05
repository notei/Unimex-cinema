using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace unimex.lenguajesv.cine.DTO
{
    class ClientesFrecuentesDTO
    {
        private int id_cliente_frecuente;
        private String nombre;
        private String apellido_paterno;
        private String user_name;
        private bool habilitado;

        public int id_ClienteFrecuente
        {
            get { return id_cliente_frecuente; }

            set { id_cliente_frecuente = value; }
        }

        public String Nombre
        {
            get { return nombre; }

            set { nombre = value; }
        }
        public String Apellido_Paterno
        {
            get { return apellido_paterno; }

            set { apellido_paterno = value; }
        }
        public String User_Name
        {
            get { return user_name; }

            set { user_name = value; }
        }
        public bool Habilitado
        {
            get { return habilitado; }

            set { habilitado = value; }
        }
    }
}
