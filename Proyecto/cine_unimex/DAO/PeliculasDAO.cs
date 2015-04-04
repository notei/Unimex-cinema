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

        public void Newpeliculas(PeliculasDTO new_pel_DTO)
        {
            String SQL_NewPeliculas = "insert into peliculas values ('"+ new_pel_DTO.Pelicula + "," + new_pel_DTO.id_Clasificacion + "," + new_pel_DTO.Duracion_min + "," + new_pel_DTO.Sinopsis +","+ new_pel_DTO.Idioma +","+ new_pel_DTO.Sonido + "," + new_pel_DTO.id_Nacionalidad + "," + new_pel_DTO.id_Genero + "," + new_pel_DTO.Estreno + ")";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL_NewPeliculas, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}

