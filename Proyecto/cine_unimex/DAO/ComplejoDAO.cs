using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using unimex.lenguajesv.cine.DTO;

namespace unimex.lenguajesv.cine.DAO
{
    class ComplejoDAO
    {
        private String SQL_Consulta_Complejos = "select cat_complejos.id_complejo AS Id , cat_complejos.nombre AS Complejo, cat_complejos.direccion AS Direccion, cat_complejos.telefono AS Telefono, cat_complejos.habilitado AS Habilitado FROM cat_complejos";
        private String Cadena = Properties.Resources.CADENA_CONEXION;

        public DataTable loadComplejos()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_Consulta_Complejos, con))
            {

                DataTable tblp = new DataTable();
                adapter.Fill(tblp);
                con.Close();
                return tblp;
            }

        }
        public void agregarComplejo(ComplejoDTO pdto)
        {
            String SQL_Agregar_Complejo = " insert into cat_complejos (nombre, direccion, telefono,habilitado) values ( '" + pdto.Nombre + "' , '" + pdto.Direccion + "', '" + pdto.Telefono + "','"+pdto.Habilitado+"')";
            SqlConnection con;
            con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand comando;
            comando = new SqlCommand(SQL_Agregar_Complejo, con);
            comando.ExecuteNonQuery();
            con.Close();
        }
        public ComplejoDTO cargarcomplejoUpdate(int id)
        {
            String SQL_Cargar_Precios = "select * from cat_complejos where id_complejo = " + id;
            ComplejoDTO  prdto = new ComplejoDTO();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL_Cargar_Precios, con);
            SqlDataReader red = cmd.ExecuteReader();
            while (red.Read())
            {
                prdto.id_Complejos = (int)red.GetInt32(0);
                prdto.Nombre = (String)red.GetString(1);
                prdto.Direccion = (String)red.GetString(2);
                prdto.Telefono = (String)red.GetString(3);
                prdto.Habilitado = (Boolean)red.GetBoolean(4);
            }
            con.Close();
            return prdto;
        }
        public void updateComplejoDTO(ComplejoDTO preciodtoup)
        {
            String SQL_Update_Precio = " UPDATE cat_complejos SET nombre = '" + preciodtoup.Nombre + "', direccion = '" + preciodtoup.Direccion + "', telefono = '" + preciodtoup.Telefono + "', habilitado '"+preciodtoup.Habilitado+"' WHERE id_complejo = " + preciodtoup.id_Complejos;
            SqlConnection con;
            con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand comando;
            comando = new SqlCommand(SQL_Update_Precio, con);
            comando.ExecuteNonQuery();
            con.Close();
        }
        public void deleteComplejoDTO(ComplejoDTO deletedto)
        {
            String SQL_Update_Precio = " DELETE FROM cat_complejos WHERE id_complejo = " + deletedto.id_Complejos;
            SqlConnection con;
            con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand comando;
            comando = new SqlCommand(SQL_Update_Precio, con);
            comando.ExecuteNonQuery();
            con.Close();
        }
        public DataTable cargaBusquedaComplejo(ComplejoDTO busdtopre)
        {
            String SQL_Buscar_Complejo = "select cat_complejos.id_complejo AS Id , cat_complejos.nombre AS Complejo, cat_complejos.direccion AS Direccion, cat_complejos.telefono AS Telefono, cat_complejos.habilitado AS Habilitado FROM cat_complejos where cat_complejos.id_complejo =" + busdtopre.id_Complejos;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            using (SqlDataAdapter adapter1 = new SqlDataAdapter(SQL_Buscar_Complejo, con))
            {

                DataTable tblpbus = new DataTable();
                adapter1.Fill(tblpbus);
                con.Close();
                return tblpbus;
            }
        }
        public DataTable LoadNombrePrecio()
        {
            String SQL_Busc_Com = "select id_complejo, nombre from cat_complejos";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_Busc_Com, con))
            {

                DataTable tbl = new DataTable();
                adapter.Fill(tbl);
                con.Close();
                return tbl;
            }
        }
    }
}
