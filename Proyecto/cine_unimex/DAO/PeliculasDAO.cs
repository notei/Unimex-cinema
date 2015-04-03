using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using unimex.lenguajesv.cine.DTO;

namespace unimex.lenguajesv.cine.DAO
{
    class PeliculasDAO
    {
        private String SQL_Consultapeliculas = "Select peliculas.id_pelicula as pelicula, peliculas.pelicula As pelicula, cat_clasificaciones_peliculas.nombre_clasificacion, peliculas.duracion_min As duracion, peliculas.sinopsis As sinopsis, peliculas.idioma As idioma, peliculas.sonido As sonido , nacionalidades.nacionalidad, cat_generos.genero, peliculas.estreno from peliculas inner join cat_clasificaciones_peliculas on cat_clasificaciones_peliculas.id_clasificacion = peliculas.id_clasificacion inner join nacionalidades on nacionalidades.id_nacionalidad = peliculas.id_nacionalidad inner join cat_generos on cat_generos.id_genero = peliculas.id_genero";
        private String Cadena = Properties.Resources.CADENA_CONEXION;

        public DataTable loadPeliculas()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_Consultapeliculas, con))
            {
                DataTable tblp = new DataTable();
                adapter.Fill(tblp);
                con.Close();
                return tblp;
            }

        }
        public void newPelicula(PeliculasDTO new_peli)
        {
            String SQL_newPelicula = "insert into peliculas (id_pelicula, pelicula, id_clasificacion, duracion_min, sinopsis, idioma, sonido, id_nacionalidad, id_genero, estreno) values ('" + new_peli.id_Pelicula + "," + new_peli.Pelicula + "," + new_peli.id_Clasificacion + "," + new_peli.Duracion_min + ", " + new_peli.Sinopsis + "," + new_peli.Sonido + "," + new_peli.id_Nacionalidad + "," + new_peli.id_Genero + "," + new_peli.Estreno + ")";

            SqlConnection con = getConexion();
            SqlCommand cmd = new SqlCommand(SQL_newPelicula, con);
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

            internal DataTable LoadPeliculas()
            {
                throw new NotImplementedException();
            }
    }
}

