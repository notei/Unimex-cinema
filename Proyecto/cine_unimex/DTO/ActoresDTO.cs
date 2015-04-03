using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace unimex.lenguajesv.cine
{
    class ActoresDTO
    {
        private int id_actor;
        private String nombre;
        private String apellido_paterno;
        private String apellido_materno;
        private int sexo;// cambio a integer porque los datos a extraer y a ingresar son enteros 0 o 1 
        private int id_nacionalidad;
        

        public int id_Actor
        {

            get { return id_actor; }

            set { id_actor = value; }

        }

        public String Nombre
        {
            get { return nombre; }

            set { nombre = value; }
        }

        public String ApellidoP
        {
            get { return apellido_paterno; }
            set { apellido_paterno = value; }

        }

        public String ApellidoM
        {
            get { return apellido_materno; }

            set { apellido_materno = value; }
        }
        public int Sexo
        {
            get { return sexo; }

            set { sexo = value; }
        }
        public int Id_Nacionalidad
        {
            get { return id_nacionalidad; }

            set { id_nacionalidad = value; }
        }
    }
}
