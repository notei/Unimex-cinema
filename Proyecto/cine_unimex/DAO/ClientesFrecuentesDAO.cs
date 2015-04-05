using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using unimex.lenguajesv.cine.DTO;

namespace unimex.lenguajesv.cine.DAO
{
    class ClientesFrecuentesDAO
    {
        private String SQL_Consulta_CF = "select clientes_frecuentes.id_cliente_frecuente AS Id , clientes_frecuentes.nombre AS Nombre, clientes_frecuentes.apellido_paterno AS ApellidoPaterno, clientes_frecuentes.user_name AS Usuario, clientes_frecuentes.habilitado AS Habilitado FROM clientes_frecuentes";
        private String Cadena = Properties.Resources.CADENA_CONEXION;

        public DataTable cargarClientesFrecuentes ()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_Consulta_CF, con))
            {
                DataTable tblcf = new DataTable();
                adapter.Fill(tblcf);
                con.Close();
                return tblcf;
            }
        }
        public void agregarClienteFrecuente (ClientesFrecuentesDTO cldto)
        {
            String SQL_Agregar_CF = " insert into clientes_frecuentes (nombre, apellido_paterno, user_name, habilitado) values ( '" + cldto.Nombre + "' , '" + cldto.Apellido_Paterno + "', '" + cldto.User_Name + "',"+cldto.Habilitado+")";
            SqlConnection con;
            con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand comando;
            comando = new SqlCommand(SQL_Agregar_CF, con);
            comando.ExecuteNonQuery();
            con.Close();
        }
    }
}
