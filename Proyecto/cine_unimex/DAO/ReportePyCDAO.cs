using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using unimex.lenguajesv.cine.DTO;

namespace unimex.lenguajesv.cine.DAO
{
    class ReportePyCDAO
    {
        private String Cadena = Properties.Resources.CADENA_CONEXION;
        //private String Cadena = "Data Source=LOCALHOST;Initial Catalog=unimex_cinema_db;Integrated Security=true";
        public DataTable Ventas_Pelicula_Complejo()
        {
            String SQL_Consulta_Proyecciones = "Select peliculas.pelicula as Película, cat_complejos.nombre as Complejo, sum (venta_proyecciones.cantidad_boletos) as Cantidad,Sum (venta_proyecciones.precio_total) as Total from venta_proyecciones inner join proyecciones on venta_proyecciones.id_proyeccion = proyecciones.id_proyeccion inner join cat_precios on venta_proyecciones.id_precio = cat_precios.id_precio inner join clientes_frecuentes on venta_proyecciones.id_cliente_frecuente = clientes_frecuentes.id_cliente_frecuente inner join peliculas on proyecciones.id_pelicula = peliculas.id_pelicula inner join  registro_ventas on registro_ventas.id_registro_venta = venta_proyecciones.id_registro_venta inner join cat_complejos on registro_ventas.id_complejo = cat_complejos.id_complejo group by  peliculas.pelicula, cat_complejos.nombre";
            SqlConnection con = getConexion();
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_Consulta_Proyecciones, con))
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
