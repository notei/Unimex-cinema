using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace unimex.lenguajesv.cine.DAO
{
    class CarteleraDAO
    {
        private String SQL_Consulta_Cartelera = "select peliculas.pelicula AS Pelicula, cat_clasificaciones_peliculas.nombre_clasificacion AS Clasificación, peliculas.duracion_min AS Duración , peliculas.sinopsis AS Sinopsis, peliculas.idioma AS Idioma, nacionalidades.nacionalidad AS Nacionalidad, cat_generos.genero AS Genero, peliculas.estreno AS Estreno from peliculas inner join cat_clasificaciones_peliculas on peliculas.id_clasificacion= cat_clasificaciones_peliculas.id_clasificacion inner join nacionalidades on nacionalidades.id_nacionalidad = peliculas.id_nacionalidad inner join cat_generos on cat_generos.id_genero = peliculas.id_genero";
        private String Cadena = Properties.Resources.CADENA_CONEXION;


        public DataTable consultaCartelera()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_Consulta_Cartelera, con))
            {
                DataTable tblcf = new DataTable();
                adapter.Fill(tblcf);
                con.Close();
                return tblcf;
            }
        }


    }
}
