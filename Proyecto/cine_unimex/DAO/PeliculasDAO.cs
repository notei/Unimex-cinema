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
        public void deletepeliculasDTO(PeliculasDTO deletedto)
        {
            String SQLLoadPeliculas = " DELETE FROM peliculas WHERE id_pelicula = " + deletedto.id_Pelicula;
            SqlConnection con;
            con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand comando;
            comando = new SqlCommand(SQLLoadPeliculas, con);
            comando.ExecuteNonQuery();
            con.Close();
        }


       public PeliculasDTO LoadPeliculas(int id)
        {
            String SQL_Conocer_pelicula = "Select * From peliculas where id_pelicula = " + id;
            PeliculasDTO peli_DTO = new PeliculasDTO();
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand(SQL_Conocer_pelicula, con);
            SqlDataReader red = cmd.ExecuteReader();
            while (red.Read())
            {
                peli_DTO.Pelicula = (String)red.GetSqlString(0);
                peli_DTO.Duracion_min = (int)red.GetSqlInt32(1);
                peli_DTO.Sinopsis = (String)red.GetSqlString(2);
                peli_DTO.Idioma = (String)red.GetSqlString(3);
                peli_DTO.Sonido = (String)red.GetSqlString(4);
                peli_DTO.Estreno = (Boolean)red.GetSqlBoolean(5);
            }
            return peli_DTO;

        }


        private SqlConnection getConexion()
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = Cadena;
        con.Open();
        return con;
    }
        public DataTable cargaBusquedaCF(PeliculasDTO busdtocf)
        {
            String SQL_Buscar_peli = "select peliculas.id_pelicula AS Id , peliculas.pelicula AS pelicula, pelicula.duracion_min AS Duracion, peliculas.sinopsis AS Sinopsis, peliculas.idioma AS Idioma, peliculas.sonido as Sonido, peliculas.estreno as Estreno FROM peliculas WHERE id_pelicula = " + busdtocf.id_Pelicula;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            using (SqlDataAdapter adapter3 = new SqlDataAdapter(SQL_Buscar_peli, con))
            {

                DataTable tblcfbus = new DataTable();
                adapter3.Fill(tblcfbus);
                con.Close();
                return tblcfbus;
            }
        }


        public DataTable LoadNombreCF()
        {
            String SQL_Busc_CF = "select id_pelicula, pelicula from peliculas";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_Busc_CF, con))
            {

                DataTable tbl = new DataTable();
                adapter.Fill(tbl);
                con.Close();
                return tbl;
            }

        }

        public void updateCFrecuenteDTO(PeliculasDTO clientefdtoup)
        {
            String SQL_Update_CF = " UPDATE peliculas SET pelicula = '" + clientefdtoup.Pelicula + "', Duracion = '" + clientefdtoup.Duracion_min + "', sinopsis = '" + clientefdtoup.Sinopsis + "', idioma = '" + clientefdtoup.Idioma + "', sonido = '" + clientefdtoup.Sonido + "', habilitado = '" + clientefdtoup.Estreno + "' WHERE id_pelicula = " + clientefdtoup.id_Pelicula;
            SqlConnection con;
            con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand comando;
            comando = new SqlCommand(SQL_Update_CF, con);
            comando.ExecuteNonQuery();
            con.Close();
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