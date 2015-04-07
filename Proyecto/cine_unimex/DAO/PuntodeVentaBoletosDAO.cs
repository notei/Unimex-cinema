using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace unimex.lenguajesv.cine.DAO
{
    class PuntodeVentaBoletosDAO
    {
        private String Cadena = Properties.Resources.CADENA_CONEXION;

        public DataTable cargarComplejoPV ()
        {
            String SQL_cargar_Complejo = "select nombre from cat_complejos";
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
        public DataTable cargarPeliculaPV()
        {
            String SQL_cargar_Pelicula = "select pelicula from peliculas";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_cargar_Pelicula, con))
            {

                DataTable tbl = new DataTable();
                adapter.Fill(tbl);
                con.Close();
                return tbl;
            }
        }

        public DataTable cargarSalaPV()
        {
            String SQL_cargar_Sala = "select nombre_sala from cat_salas_complejos";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_cargar_Sala, con))
            {

                DataTable tbl = new DataTable();
                adapter.Fill(tbl);
                con.Close();
                return tbl;
            }
        }

        public DataTable cargarHorarioPV()
        {
            String SQL_cargar_Horario = "select horario from proyecciones";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_cargar_Horario, con))
            {

                DataTable tbl = new DataTable();
                adapter.Fill(tbl);
                con.Close();
                return tbl;
            }
        }

        public DataTable cargarTipoBoletoPV()
        {
            String SQL_cargar_Tipo_Boleto = "select nombre from cat_precios";
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
        
    }
}
