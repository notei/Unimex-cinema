using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace unimex.lenguajesv.cine.DTO
{
    class UsuariosDTO
    {
        private int idUsuario;
        private string nombre;
        private string apellido_paterno;
        private string nombre_usuario;
        private string contrasena;
        private int id_tipo_usuario;

        public int idusuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string ApPaterno
        {
            get { return apellido_paterno; }
            set { apellido_paterno = value; }
        }

        public string NomUsuario
        {
            get { return nombre_usuario; }
            set { nombre_usuario = value; }
        }

        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }

        public int Id_Tipo_Usuario
        {
            get { return id_tipo_usuario; }
            set { id_tipo_usuario = value; }
        }
    }
}