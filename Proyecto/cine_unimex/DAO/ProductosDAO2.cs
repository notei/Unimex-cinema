using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace unimex.lenguajesv.cine.DAO
{
    class ProductosDAO2
    {
        private String SQL_Consulta_Productos = "select cat_productos.id_producto,precio,disponibilidad, cat_tipo_productos.nombre,cat_proveedor.proveedor";
            private String Cadena = Properties.Resources.CADENA_CONEXION;

    public DataTable LoadProductos()

    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = Cadena ;
        using (SqlDataAdapter adapter = new SqlDataAdapter (SQL_Consulta_Productos,con))
        {
            DataTable tbl = new DataTable ();
            adapter.Fill(tbl);
            return tbl;

        }

    }
    }
}
