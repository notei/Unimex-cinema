using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace unimex.lenguajesv.cine.DAO
{
    class PuntodeVentaBoletosDAO
    {
        private String Cadena = Properties.Resources.CADENA_CONEXION;

        public DataTable cargarComplejoPV ()
        {
            String SQL_cargar_Complejo = "select nombre from cat_complejos";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_cargar_Complejo, con))
            {

                DataTable tbl = new DataTable();
                adapter.Fill(tbl);
                con.Close();
                return tbl;
            }
        }
    }
}
