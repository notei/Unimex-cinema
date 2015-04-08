using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace unimex.lenguajesv.cine.DAO
{
    class PuntodeVentaDulceriaDAO
    {

        private String Cadena = Properties.Resources.CADENA_CONEXION;

        public DataTable seleccionarProductoPVD()
        {
            String SQL_seleccionar_Producto = "select nombre from cat_productos";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_seleccionar_Producto, con))
            {

                DataTable tbl = new DataTable();
                adapter.Fill(tbl);
                con.Close();
                return tbl;
            }

        }

        public DataTable seleccionarCombosPVD()
        {
            String SQL_seleccionar_Combos = "select nombre from productos_combos";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_seleccionar_Combos, con))
            {

                DataTable tbl = new DataTable();
                adapter.Fill(tbl);
                con.Close();
                return tbl;
            }
        }
    }
}