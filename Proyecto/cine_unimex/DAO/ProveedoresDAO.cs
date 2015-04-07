using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using unimex.lenguajesv.cine.DTO;

//DAO realizado por Gonzalez Reyes Berenice Izamar

namespace unimex.lenguajesv.cine.DAO
{
    class ProveedoresDAO
    {

        private String SQL_Consulta_Proveedores = "select cat_proveedor.id_proveedor AS Id , cat_proveedor.proveedor AS NomProveedor, cat_proveedor.detalles AS Producto, cat_proveedor.habilitado AS Permiso from cat_proveedor";
        private String Cadena = Properties.Resources.CADENA_CONEXION;

        public DataTable LoadProveedor()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_Consulta_Proveedores, con))
            {

                DataTable tbl = new DataTable();
                adapter.Fill(tbl);
                con.Close();
                return tbl;
            }
        }

        public void agregarProveedor(ProveedoresDTO q)
        {

            String SQL_Agregar_Proveedor = " insert into cat_proveedor (proveedor,detalles, habilitado) values ( '" + q.proveedores + "' , '" + q.detalle + "' , '" + q.Habilitado + "')";



            SqlConnection con;
            con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();

            SqlCommand comando;
            comando = new SqlCommand(SQL_Agregar_Proveedor, con);
            comando.ExecuteNonQuery();
            con.Close();

        }

        public ProveedoresDTO cargarProveedoresUpdate(int id)
        {
            String SQL_Cargar_Proveedor = "select * from cat_proveedor where id_proveedor = " + id;
            ProveedoresDTO useredit = new ProveedoresDTO();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL_Cargar_Proveedor, con);
            SqlDataReader red = cmd.ExecuteReader();
            while (red.Read())
            {
                useredit.idproveedor = (int)red.GetSqlInt32(0);
                useredit.proveedores = (String)red.GetSqlString(1);
                useredit.detalle = (String)red.GetSqlString(2);
                useredit.Habilitado = (bool)red.GetBoolean(3);
            }
            con.Close();
            return useredit;
        }

        public void updateProveedorDTO(ProveedoresDTO preciodtoup)
        {
            String SQL_Update_Proveedor = " UPDATE cat_proveedor SET proveedor = '" + preciodtoup.proveedores + "', detalles = '" + preciodtoup.detalle + "', habilitado = '" + preciodtoup.Habilitado + "' WHERE id_proveedor  = " + preciodtoup.idproveedor;
            SqlConnection con;
            con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand comando;
            comando = new SqlCommand(SQL_Update_Proveedor, con);
            comando.ExecuteNonQuery();
            con.Close();
        }

        public void deleteUsuarioDTO(ProveedoresDTO deletedto)
        {
            String SQL_Update_Proveedor = " DELETE FROM cat_proveedor WHERE id_proveedor = " + deletedto.idproveedor;
            SqlConnection con;
            con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand comando;
            comando = new SqlCommand(SQL_Update_Proveedor, con);
            comando.ExecuteNonQuery();
            con.Close();
        }

        public DataTable cargaBusquedaProveedor(ProveedoresDTO busdtopre)
        {
            String SQL_Buscar_Proveedor = "select cat_proveedor.id_proveedor AS Id , cat_proveedor.proveedor AS Proveedor, cat_proveedor.detalles AS Detalle, cat_proveedor.habilitado AS Habilitado from cat_proveedor where cat_proveedor.id_proveedor = " + busdtopre.idproveedor;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            using (SqlDataAdapter adapter1 = new SqlDataAdapter(SQL_Buscar_Proveedor, con))
            {

                DataTable tblpbus = new DataTable();
                adapter1.Fill(tblpbus);
                con.Close();
                return tblpbus;
            }
        }

        public DataTable LoadNombreProveedor()
        {
            String SQL_Busc_Proveedor = "select id_proveedor, proveedor from cat_proveedor";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_Busc_Proveedor, con))
            {

                DataTable tbl = new DataTable();
                adapter.Fill(tbl);
                con.Close();
                return tbl;
            }
        }

    }
}
