using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using unimex.lenguajesv.cine.DTO;

namespace unimex.lenguajesv.cine.DAO
{
    class PuntodeVentaBoletosDAO
    {
        private String Cadena = Properties.Resources.CADENA_CONEXION;

        public DataTable cargarComplejoPV ()
        {
            String SQL_cargar_Complejo = "select id_complejo, nombre from cat_complejos";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_cargar_Complejo, con))
            {

                DataTable tbl = new DataTable();
                adapter.Fill(tbl);
                con.Close();
                return tbl;
            }
        }
        

        public DataTable cargarTipoBoletoPV()
        {
            String SQL_cargar_Tipo_Boleto = "select id_precio, nombre from cat_precios";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_cargar_Tipo_Boleto, con))
            {

                DataTable tbl = new DataTable();
                adapter.Fill(tbl);
                con.Close();
                return tbl;
            }
        }


        public  DataTable cargarDgvPelicula ()
        {
            String SQL_Cargar_Dgv_Pelicula = "select cat_complejos.nombre, cat_salas_complejos.nombre_sala, peliculas.pelicula, proyecciones.horario FROM proyecciones INNER JOIN peliculas ON proyecciones.id_pelicula = peliculas.id_pelicula INNER JOIN cat_salas_complejos ON cat_salas_complejos.id_sala = proyecciones.id_sala INNER JOIN cat_complejos ON cat_complejos.id_complejo = cat_salas_complejos.id_complejo " ;
            PuntodeVentaBoletosDTO prdto = new PuntodeVentaBoletosDTO();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_Cargar_Dgv_Pelicula, con))
            {

                DataTable tbl = new DataTable();
                adapter.Fill(tbl);
                con.Close();
                return tbl;
            }

        }
        public PuntodeVentaBoletosDTO cargarComplejoPV(int id)
        {
            String SQL_Cargar_ComplejoPV = "select id_complejo, nombre from cat_complejos where id_complejo = " + id;
            PuntodeVentaBoletosDTO prdto = new PuntodeVentaBoletosDTO();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL_Cargar_ComplejoPV, con);
            SqlDataReader red = cmd.ExecuteReader();
            while (red.Read())
            {
                prdto.Id_Complejo = (int)red.GetInt32(0);
                prdto.Nombre = (String)red.GetString(1);               
            }
            con.Close();
            return prdto;
        }
        public DataTable cargadtg (PuntodeVentaBoletosDTO puntoven)
        {
            String SQL_Buscar_pvv = "select cat_complejos.nombre, cat_salas_complejos.nombre_sala, peliculas.pelicula, proyecciones.horario FROM proyecciones INNER JOIN peliculas ON proyecciones.id_pelicula = peliculas.id_pelicula INNER JOIN cat_salas_complejos ON cat_salas_complejos.id_sala = proyecciones.id_sala INNER JOIN cat_complejos ON cat_complejos.id_complejo = cat_salas_complejos.id_complejo where cat_complejos.id_complejo = "+puntoven.Id_Complejo;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            using (SqlDataAdapter adapter1 = new SqlDataAdapter(SQL_Buscar_pvv, con))
            {

                DataTable tblpbus = new DataTable();
                adapter1.Fill(tblpbus);
                con.Close();
                return tblpbus;
            }
        }
    }
}
