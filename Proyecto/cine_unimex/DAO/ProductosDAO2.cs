using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using unimex.lenguajesv.cine.DTO;

namespace unimex.lenguajesv.cine.DAO
{
    class ProductosDAO2
    {
        private String SQL_Consulta_Productos2 = "select cat_productos.id_producto,precio,disponibilidad, cat_tipo_productos.nombre,cat_proveedor.proveedor";
            private String Cadena = Properties.Resources.CADENA_CONEXION;

    public DataTable LoadProductos2()

    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = Cadena ;
        using (SqlDataAdapter adapter = new SqlDataAdapter (SQL_Consulta_Productos2,con))
        {
            DataTable tbl = new DataTable ();
            adapter.Fill(tbl);
            con.Close();
            return tbl;
            

        }
       

    }
        //insertar registros
        public void newproductos2(ProductosDTO2 proy_DTO_new)
        {
            String SQL_NewProducto = "insert into cat_productos values ( " + proy_DTO_new.Nombre + ", " + proy_DTO_new.Descripcion +"," + proy_DTO_new.Precio + "," + proy_DTO_new.Disponibilidad + "," + proy_DTO_new.Id_tipo_producto + "," + proy_DTO_new.Id_proveedor +")";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            SqlCommand cmd = new SqlCommand (SQL_Consulta_Productos2,con);
            cmd.ExecuteNonQuery();
            con.Close();


        }
    }
}
