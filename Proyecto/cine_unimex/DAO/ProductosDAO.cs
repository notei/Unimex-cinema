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
        public ProductosDTO cargarProductosUpdate(int id)
        {
            String SQL_Cargar_Productos = "select * from cat_tipo_productos where id_tipo_producto = " + id;
            ProductosDTO prdto = new ProductosDTO();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL_Cargar_Productos, con);
            SqlDataReader red = cmd.ExecuteReader();
            while (red.Read())
            {
                prdto.IdTipoProducto = (int)red.GetInt32(0);
                prdto.Nombre = (String)red.GetString(1);
                prdto.Descripcion = (String)red.GetString(2);
                prdto.Habilitar = (Boolean)red.GetBoolean(3);
            }
            con.Close();
            return prdto;
        }
        public void updatePoductoDTO(ProductosDTO prodtoup)
        {
            String SQL_Update_Producto = " UPDATE cat_tipo_productos SET nombre = '" + prodtoup.Nombre + "', descripcion = '" + prodtoup.Descripcion + "', habilitado = '" + prodtoup.Habilitar + "' WHERE id_tipo_producto = " + prodtoup.IdTipoProducto;
            SqlConnection con;
            con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand comando;
            comando = new SqlCommand(SQL_Update_Producto, con);
            comando.ExecuteNonQuery();
            con.Close();
        }
        public void deleteTPDTO(ProductosDTO deletedtotp)
        {
            String SQL_Update_TP = " DELETE FROM cat_tipo_productos WHERE id_tipo_producto = " + deletedtotp.IdTipoProducto;
            SqlConnection con;
            con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand comando;
            comando = new SqlCommand(SQL_Update_TP, con);
            comando.ExecuteNonQuery();
            con.Close();
        }
    }
}