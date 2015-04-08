using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using unimex.lenguajesv.cine.DTO;

namespace unimex.lenguajesv.cine.DAO
{
    class CarteleraDAO
    {
        private String SQL_Consulta_Cartelera = "select peliculas.id_pelicula AS Id, peliculas.pelicula AS Pelicula, cat_clasificaciones_peliculas.nombre_clasificacion AS Clasificación, peliculas.duracion_min AS Duración , peliculas.sinopsis AS Sinopsis, peliculas.idioma AS Idioma, nacionalidades.nacionalidad AS Nacionalidad, cat_generos.genero AS Genero, peliculas.estreno AS Estreno from peliculas inner join cat_clasificaciones_peliculas on peliculas.id_clasificacion= cat_clasificaciones_peliculas.id_clasificacion inner join nacionalidades on nacionalidades.id_nacionalidad = peliculas.id_nacionalidad inner join cat_generos on cat_generos.id_genero = peliculas.id_genero inner join proyecciones on proyecciones.id_pelicula = peliculas.id_pelicula where proyecciones.horario >= GETDATE()";
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
        public DataTable cargarDetallesCart (int id)
        {
            String SQL_Cargar_Detalles = "select proyecciones.id_proyeccion AS Id , cat_complejos.nombre AS Complejo, cat_salas_complejos.nombre_sala AS Sala, peliculas.pelicula AS Película, convert (varchar,proyecciones.horario,100)as Horario from proyecciones inner join cat_salas_complejos on proyecciones.id_sala = cat_salas_complejos.id_sala inner join peliculas on peliculas.id_pelicula = proyecciones.id_pelicula inner join cat_complejos on cat_complejos.id_complejo=cat_salas_complejos.id_complejo  where peliculas.id_pelicula =" + id;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            using (SqlDataAdapter adapter1 = new SqlDataAdapter(SQL_Cargar_Detalles, con))
            {

                DataTable tblpbus = new DataTable();
                adapter1.Fill(tblpbus);
                con.Close();
                return tblpbus;
            }
        }


    }
}
