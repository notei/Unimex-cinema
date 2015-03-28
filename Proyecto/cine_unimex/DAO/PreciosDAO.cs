using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace unimex.lenguajesv.cine.DAO
{
    class PreciosDAO
    {

        private String SQL_Consulta_Precios = "select cat_precios.id_precio AS Id , cat_precios.nombre AS Boleto, cat_precios.descripcion AS Descripción, cat_precios.precio AS Precio FROM cat_precios";
        private String Cadena = Properties.Resources.CADENA_CONEXION;

        public DataTable loadPrecios ()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_Consulta_Precios, con))
            {

                DataTable tblp = new DataTable();
                adapter.Fill(tblp);
                con.Close();
                return tblp;
            }
           
        }

    }
}
