using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace unimex.lenguajesv.cine
{
    class totalVentaBoletosyPorComplejoDAO
    {
        private String SQL_total = "select registro_ventas.id_registro_venta, CAST(CONVERT(datetime,registro_ventas.fecha_venta, 1)as date)[Fecha] , cat_complejos.nombre,cat_tipo_pago.tipo_pago from registro_ventas inner join cat_complejos on registro_ventas.id_complejo = cat_complejos.id_complejo inner join cat_tipo_pago on cat_tipo_pago.id_tipo_pago = registro_ventas.id_tipo_pago";
        private String Cadena = Properties.Resources.CADENA_CONEXION;
        //private String Cadena = "Data Source=LOCALHOST;Initial Catalog=unimex_cinema_db;Integrated Security=true";
      
        public DataTable LoadTotal()
        {
            SqlConnection con = getConexion();
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_total, con))
            {

                DataTable tbl = new DataTable();
                adapter.Fill(tbl);
                con.Close();
                return tbl;
            }

        }

        private SqlConnection getConexion()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            return con;
        }
    }
}
