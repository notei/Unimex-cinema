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
            String SQL_Agregar_CF = " insert into clientes_frecuentes (nombre, apellido_paterno, user_name, habilitado) values ( '" + cldto.Nombre + "' , '" + cldto.Apellido_Paterno + "', '" + cldto.User_Name + "','"+cldto.Habilitado+"')";
            SqlConnection con;
            con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand comando;
            comando = new SqlCommand(SQL_Agregar_CF, con);
            comando.ExecuteNonQuery();
            con.Close();
        }
        public ClientesFrecuentesDTO cargarCFUpdate(int id)
        {
            String SQL_Cargar_CF = "select * from clientes_frecuentes where id_cliente_frecuente = " + id;
            ClientesFrecuentesDTO cfre_dto = new ClientesFrecuentesDTO();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL_Cargar_CF, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                cfre_dto.id_ClienteFrecuente = (int)rd.GetInt32(0);
                cfre_dto.Nombre = (String)rd.GetString(1);
                cfre_dto.Apellido_Paterno = (String)rd.GetString(2);
                cfre_dto.User_Name = (String)rd.GetString(3);
                cfre_dto.Habilitado = (Boolean)rd.GetBoolean(4);
            }
            con.Close();
            return cfre_dto;
        }
        public void updateCFrecuenteDTO(ClientesFrecuentesDTO clientefdtoup)
        {
            String SQL_Update_CF = " UPDATE clientes_frecuentes SET nombre = '" + clientefdtoup.Nombre + "', apellido_paterno = '" + clientefdtoup.Apellido_Paterno + "', user_name = '" + clientefdtoup.User_Name + "', habilitado = '" + clientefdtoup.Habilitado + "' WHERE id_cliente_frecuente = " + clientefdtoup.id_ClienteFrecuente;
            SqlConnection con;
            con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand comando;
            comando = new SqlCommand(SQL_Update_CF, con);
            comando.ExecuteNonQuery();
            con.Close();
        }
        public void deleteCFDTO (ClientesFrecuentesDTO deletecfdto)
        {
            String SQL_Update_CF = " DELETE FROM clientes_frecuentes WHERE id_cliente_frecuente = " + deletecfdto.id_ClienteFrecuente;
            SqlConnection con;
            con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand comando;
            comando = new SqlCommand(SQL_Update_CF, con);
            comando.ExecuteNonQuery();
            con.Close();
        }
    }
}
