using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using unimex.lenguajesv.cine.DTO;

namespace unimex.lenguajesv.cine.DAO
{
    class UsuariosDAO
    {

        private String SQL_Consulta_Usuarios = "select usuarios.idUsuario AS Id , usuarios.nombre AS Nombre, usuarios.apellido_paterno AS ApPaterno, usuarios.nombre_usuario AS NombreUsuario, usuarios.contrasena AS Contraseña, usuarios.id_tipo_usuario AS TipoUsuario from usuarios";
        private String Cadena = Properties.Resources.CADENA_CONEXION;

        public DataTable LoadUsuarios()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_Consulta_Usuarios, con))
            {

                DataTable tbl = new DataTable();
                adapter.Fill(tbl);
                con.Close();
                return tbl;
            }
        }

        public void agregarUsuario(UsuariosDTO n)
        {

            String SQL_Agregar_Usuario = " insert into usuarios (nombre, apellido_paterno, nombre_usuario, contrasena, id_tipo_usuario) values ('" + n.Nombre + "' , '" + n.ApPaterno + "','" + n.NomUsuario + "','" + n.Contrasena + "','" + n.Id_Tipo_Usuario + "')";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();

            SqlCommand cmd = new SqlCommand(SQL_Agregar_Usuario, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public UsuariosDTO cargarUsuariosUpdate(int id)
        {
            String SQL_Cargar_Usuario = "select * from usuarios where idUsuario = " + id;
            UsuariosDTO useredit = new UsuariosDTO();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL_Cargar_Usuario, con);
            SqlDataReader red = cmd.ExecuteReader();
            while (red.Read())
            {
                useredit.idusuario = (int)red.GetSqlInt32(0);
                useredit.Nombre = (String)red.GetSqlString(1);
                useredit.ApPaterno = (String)red.GetSqlString(2);
                useredit.NomUsuario = (String)red.GetSqlString(3);
                useredit.Contrasena = (String)red.GetSqlString(4);
                useredit.Id_Tipo_Usuario = (int)red.GetSqlInt32(5);
            }
            con.Close();
            return useredit;
        }

        public void updateUsuariosDTO(UsuariosDTO preciodtoup)
        {
            String SQL_Update_Usuario = " UPDATE usuarios SET nombre = '" + preciodtoup.Nombre + "', apellido_paterno = '" + preciodtoup.ApPaterno + "', nombre_usuario = " + preciodtoup.NomUsuario + "', contrasena = " + preciodtoup.Contrasena + "', id_tipo_usuario = " + preciodtoup.Id_Tipo_Usuario + " WHERE idUsuario = " + preciodtoup.idusuario;
            SqlConnection con;
            con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand comando;
            comando = new SqlCommand(SQL_Update_Usuario, con);
            comando.ExecuteNonQuery();
            con.Close();
        }

        public void deleteUsuarioDTO(UsuariosDTO deletedto)
        {
            String SQL_Update_Usuario = " DELETE FROM usuarios WHERE idUsuario = " + deletedto.idusuario;
            SqlConnection con;
            con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand comando;
            comando = new SqlCommand(SQL_Update_Usuario, con);
            comando.ExecuteNonQuery();
            con.Close();
        }

        public DataTable cargaBusquedaUsuario(UsuariosDTO busdtopre)
        {
            String SQL_Buscar_Usuario = "select usuarios.idUsuario AS Id , usuarios.nombre AS Nombre, usuarios.apellido_paterno AS Apellido, usuarios.nombre_usuario AS Usario, usuarios.contrasena AS Password, usuarios.id_tipo_usuario AS TUsuario  from usuarios where usuarios.idUsuario = " + busdtopre.idusuario;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            using (SqlDataAdapter adapter1 = new SqlDataAdapter(SQL_Buscar_Usuario, con))
            {

                DataTable tblpbus = new DataTable();
                adapter1.Fill(tblpbus);
                con.Close();
                return tblpbus;
            }
        }


        public DataTable LoadNombreUsuario()
        {
            String SQL_Busc_Usuario = "select idUsuario, nombre from usuarios";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_Busc_Usuario, con))
            {

                DataTable tbl = new DataTable();
                adapter.Fill(tbl);
                con.Close();
                return tbl;
            }
        }
    }
}
