
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;//Libreria para la conexion con sql server
using System.Linq;
using System.Text;
using unimex.lenguajesv.cine.DTO;//Libreria parala conexion con la clase productos_combosDTO
using unimex.lenguajesv.cine.views;


namespace unimex.lenguajesv.cine.DAO
{
    class ProductosCombosDAO
    {
        //Consulta del conteido de la tabla productos_combos
        private String SQL_Productos_Combos = "SELECT * FROM productos_combos";
        private String Cadena = Properties.Resources.CADENA_CONEXION;
        //Cadena de conexión para SQLServer:private String Cadena = "Data Source=LOCALHOST;Initial Catalog=unimex_cinema_db;Integrated Security=true";

        public DataTable LoadProductosCombos()
        {
            //Codigo para realizar la conexion a la base de datos
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_Productos_Combos, con))
            {

                DataTable tblp = new DataTable();
                adapter.Fill(tblp);
                con.Close();
                return tblp;
            }
        }
        public void newProductosCombos(ProductosCombosDTO new_prodC)
        {
            //Query para insertar un nuevo registro a la tabla productos combos
            String SQL_NewProductosCombos = "insert into productos_combos (nombre,descripcion,precio,habilitado) values ('" + new_prodC.Nombre + "','" + new_prodC.Descripcion + "','" + new_prodC.Precio + "','" + new_prodC.Habilitado + "')";
            Console.WriteLine(SQL_NewProductosCombos);
            //Codigo para realizar la conexion a la base de datos
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL_NewProductosCombos, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void editProductosCombos(ProductosCombosDTO up_prodC)
        {
            //Query para modificar un registro de la tabla productos combos
            String SQL_UpDateProductosCombos = "UPDATE productos_combos SET nombre='" + up_prodC.Nombre + "',descripcion='" + up_prodC.Descripcion + "',precio='" + up_prodC.Precio + "',Habilitado='" + up_prodC.Habilitado + "'WHERE id_combo='" + up_prodC.Id_Combo + "'";
            Console.WriteLine(SQL_UpDateProductosCombos);
            //Codigo para realizar la conexion a la base de datos
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL_UpDateProductosCombos, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void deleteProductosCombos(ProductosCombosDTO del_prodC)
        {
            //Query para eliminar un registro de la talba productos combos
            String SQL_DeleteProductosCombos = "delete productos_combos where id_combo = " + del_prodC.Id_Combo;
            Console.WriteLine(SQL_DeleteProductosCombos);
            //Codigo para realizar la conexion a la base de datos
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL_DeleteProductosCombos, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}