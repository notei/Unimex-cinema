using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace unimex.lenguajesv.cine.DTO
{
    public class UsuarioDTO
    {
        private long idUsuario;
        private String nombre;
        private String apellidPaterno;
        private String nombreUsuario;
        private String contrasena;

        public long IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public String ApellidPaterno
        {
            get { return apellidPaterno; }
            set { apellidPaterno = value; }
        }


        public String NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }


        public String Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }

    }
}
