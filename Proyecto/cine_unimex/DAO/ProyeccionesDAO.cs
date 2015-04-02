using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using unimex.lenguajesv.cine.DTO;
namespace unimex.lenguajesv.cine.DAO
{
    class ProyeccionesDAO
    {

        private String SQL_Consulta_Proyecciones = "select proyecciones.id_proyeccion AS Id , cat_salas_complejos.nombre_sala AS Sala, peliculas.pelicula AS Película, convert (varchar,proyecciones.horario,100)as Horario from proyecciones inner join cat_salas_complejos on proyecciones.id_sala = cat_salas_complejos.id_sala inner join peliculas on peliculas.id_pelicula = proyecciones.id_pelicula";
        private String Cadena = Properties.Resources.CADENA_CONEXION;
        //private String Cadena = "Data Source=LOCALHOST;Initial Catalog=unimex_cinema_db;Integrated Security=true";
        public DataTable LoadProyecciones()
        {
            SqlConnection con = getConexion();
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_Consulta_Proyecciones, con))
            {

                DataTable tbl = new DataTable(); 
                adapter.Fill(tbl);
                con.Close();
                return tbl;
            }



        }

        public void newProyeccion (ProyeccionesDTO new_proy)
        {
            String SQL_NewProyeccion = "insert into proyecciones (id_sala,id_pelicula,horario) values (" + new_proy.idsala + "," + new_proy.idpelicula + ",convert(datetime,'" + new_proy.fechas + "',102))";

            SqlConnection con = getConexion();
            SqlCommand cmd = new SqlCommand(SQL_NewProyeccion, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public DataTable Loadpeliculas()
        {
            String SQL_Consulta_Peliculas = "select id_pelicula, pelicula from peliculas";
            SqlConnection con = getConexion();
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_Consulta_Peliculas, con))
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

        public DataTable LoadComplejos()
        {
            String SQL_Consulta_complejos = "select id_complejo, nombre from cat_complejos";
            SqlConnection con = getConexion();
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_Consulta_complejos, con))
            {

                DataTable tbl = new DataTable();
                adapter.Fill(tbl);
                con.Close();
                return tbl;
            }
        }
        public DataTable LoadSalas(int Idcomplejo)
        {
            String SQL_Consulta_Salas = "select id_sala, id_complejo, nombre_sala from cat_salas_complejos where id_complejo = "+ Idcomplejo;
            SqlConnection con = getConexion();
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_Consulta_Salas, con))
            {

                DataTable tbl = new DataTable();
                adapter.Fill(tbl);
                con.Close();
                return tbl;
            }

        }
    }
}
