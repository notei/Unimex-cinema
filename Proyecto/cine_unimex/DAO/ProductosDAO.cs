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

        /* public void agregarUsuario(ProductosDTO n)
        {
            verificar consulta con respecto al nombre de usuario, no necesita ser ingresado
             * Faltan apostrofos (comillas simples) para los campos de tipo texto
             * Modifico campo nombre para mostrar ejemplo.
           
            String SQL_Agregar_Productos= " insert into usuarios (idUsuario, nombre, apellido_paterno, nombre_usuario, contrasena, id_tipo_usuario) values ( " + n.idusuario + " , '" + n.Nombre + "' , " + n.ApPaterno + "," + n.NomUsuario + "," + n.Contrasena + "," + n.Id_Tipo_Usuario + ")";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();

            SqlCommand cmd = new SqlCommand(SQL_Agregar_Productos, con);
            cmd.ExecuteNonQuery();
            con.Close();  

        }*/


    }
}
