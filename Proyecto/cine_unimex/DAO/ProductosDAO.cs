using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using unimex.lenguajesv.cine.DTO;


namespace unimex.lenguajesv.cine.DAO
{
    class ProductosDAO
    {
        private String SQL_Consulta_Productos = "select  cat_tipo_productos.id_tipo_producto AS Id , cat_tipo_productos.nombre AS Nombre, cat_tipo_productos.descripcion AS Descripcion, cat_tipo_productos.habilitado AS Habilitado from cat_tipo_productos";
        private String Cadena = Properties.Resources.CADENA_CONEXION;

        public DataTable LoadProductos()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_Consulta_Productos, con))
            {

                DataTable tbl = new DataTable();
                adapter.Fill(tbl);
                con.Close();
                return tbl;
            }
        }

        public void agregarProducto(ProductosDTO n)
        {

            String SQL_Agregar_Producto = " insert into cat_tipo_productos(nombre,descripcion, habilitado) values ( '" + n.Nombre + "' , '" + n.Descripcion + "' , '" + n.Habilitar + "')";



            SqlConnection con;
            con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();

            SqlCommand comando;
            comando = new SqlCommand(SQL_Agregar_Producto, con);
            comando.ExecuteNonQuery();
            con.Close();

        }


    }
}
