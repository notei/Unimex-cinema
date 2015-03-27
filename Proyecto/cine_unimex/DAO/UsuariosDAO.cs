using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace unimex.lenguajesv.cine.DAO
{
    class UsuariosDAO
    {
        /*Corrijo consulta, agregando "FROM" debido a que solo pedia campos pero no daba la ubicación de la tabla
        Y en el mainScreen agrego al tool strip usuarios y mando llamar al formulario */
        private String SQL_Consulta_Usuarios = "select usuarios.idUsuario AS Id , usuarios.nombre AS Nombre, usuarios.apellido_paterno AS ApPaterno, usuarios.nombre_usuario AS NombreUsuario, usuarios.contrasena AS Contraseña, usuarios.id_tipo_usuario AS TipoUsuario from usuarios";
        private String Cadena = Properties.Resources.CADENA_CONEXION;

        public DataTable LoadUsuarios()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_Consulta_Usuarios, con))
            {

                DataTable tbl = new DataTable();
                adapter.Fill(tbl);
                return tbl;
            }



        }

    }
}
