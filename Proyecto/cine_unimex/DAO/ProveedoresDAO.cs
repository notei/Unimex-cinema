using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

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
    }
}