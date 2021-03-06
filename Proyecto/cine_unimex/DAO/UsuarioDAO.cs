﻿using System;
using System.Collections.Generic;
using System.Linq;

// Añadimos los espacios de nombres necesarios para trabajar con SQL Server
using System.Data;
using System.Data.SqlClient;

// Usaremos un StringBuilder, así que incluiremos System.Text.
// Dado que necesitaremos un ArrayList, también añadiremos System.Collections.
using System.Text;
using System.Collections;

using unimex.lenguajesv.cine.DTO;

namespace unimex.lenguajesv.cine.DAO
{
    class UsuarioDAO
    {
        private String LOGIN_USUARIO = "SELECT * FROM usuarios WHERE nombre_usuario= @usr AND contrasena=@pass ";

        public UsuarioDTO login(String userName, String password)
        {
            SqlConnection con = null;
            con = new SqlConnection();
            //con.ConnectionString = "Data Source=LOCALHOST;Initial Catalog=unimex_cinema_db;Integrated Security=true";
            con.ConnectionString = Properties.Resources.CADENA_CONEXION;
            
            
            con.Open();
            SqlCommand sqlCommand = new SqlCommand(LOGIN_USUARIO, con);
            
            //ASigna los parámetros
            sqlCommand.Parameters.Add(new SqlParameter("@usr", userName));
            sqlCommand.Parameters.Add(new SqlParameter("@pass", password));

            SqlDataReader sqlReader = sqlCommand.ExecuteReader();

            

            UsuarioDTO usrDto = null;
            if (sqlReader.Read())
            {
                usrDto = new UsuarioDTO();
                usrDto.Nombre = (String)sqlReader["nombre"];
                usrDto.ApellidPaterno = (String)sqlReader["apellido_paterno"];
                usrDto.NombreUsuario = (String)sqlReader["nombre_usuario"];
                usrDto.IdUsuario = (int)sqlReader["idUsuario"];
            }

            return usrDto;
        }

    }
}
