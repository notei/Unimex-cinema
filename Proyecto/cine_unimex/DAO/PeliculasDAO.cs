﻿using System;
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
        private String SQL_Consultapeliculas = "Select peliculas.id_pelicula as pelicula, peliculas.pelicula As pelicula, cat_clasificaciones_peliculas.id_clasificacion, peliculas.duracion_min As duracion, peliculas.sinopsis As sinopsis, peliculas.idioma As idioma, peliculas.sonido As sonido , nacionalidades.nacionalidad, cat_generos.genero, peliculas.estreno from peliculas inner join cat_clasificaciones_peliculas on cat_clasificaciones_peliculas.id_clasificacion = peliculas.id_clasificacion inner join nacionalidades on nacionalidades.id_nacionalidad = peliculas.id_nacionalidad inner join cat_generos on cat_generos.id_genero = peliculas.id_genero";
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
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL_Conocer_pelicula, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                peli_DTO.id_Pelicula = (int)rd.GetInt32(0);
                peli_DTO.Pelicula = (String)rd.GetSqlString(1);
                peli_DTO.id_Clasificacion = (int)rd.GetInt32(2);
                peli_DTO.Duracion_min = (int)rd.GetSqlInt32(3);
                peli_DTO.Sinopsis = (String)rd.GetSqlString(4);
                peli_DTO.Idioma = (String)rd.GetString(5);
                peli_DTO.Sonido = (String)rd.GetSqlString(6);
                peli_DTO.id_Nacionalidad = (int)rd.GetInt32(7);
                peli_DTO.id_Genero = (int)rd.GetInt32(8);
                peli_DTO.Estreno = (Boolean)rd.GetSqlBoolean(9);
            }
            con.Close();
            return peli_DTO;

        }
       public DataTable loadidClasificacion(int idclas)
       {
           String SQL_Buscar_idclas = "select id_clasificacion from cat_clasificaciones_peliculas where id_clasificacion="+idclas;
           SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            using (SqlDataAdapter adapter3 = new SqlDataAdapter(SQL_Buscar_idclas, con))
            {

                DataTable tblcfbus = new DataTable();
                adapter3.Fill(tblcfbus);
                con.Close();
                return tblcfbus;
            }
        }
       
        public DataTable cargaBusquedaCF(PeliculasDTO busdtocf)
        {
            String SQL_Buscar_peli = "SELECT * FROM peliculas WHERE id_pelicula = " + busdtocf.id_Pelicula;
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
        public DataTable Loadidclasificacion()
        {
            String SQL_Busc_CF = "select id_clasificacion from cat_clasificaciones_peliculas";
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
        public DataTable Loadidnacionalidad()
        {
            String SQL_Busc_CF1 = "select id_nacionalidad from nacionalidades";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_Busc_CF1, con))
            {

                DataTable tbl = new DataTable();
                adapter.Fill(tbl);
                con.Close();
                return tbl;
            }

        }
        public DataTable Loadidgenero()
        {
            String SQL_Busc_CF1 = "select id_genero from cat_generos";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_Busc_CF1, con))
            {

                DataTable tbl = new DataTable();
                adapter.Fill(tbl);
                con.Close();
                return tbl;
            }

        }
        public void updateCFrecuenteDTO(PeliculasDTO clientefdtoup)
        {
            String SQL_Update_CF = " UPDATE peliculas SET Pelicula = '" + clientefdtoup.Pelicula +  "', id_clasificacion = " + clientefdtoup.id_Clasificacion + ", duracion_min = " + clientefdtoup.Duracion_min + ", sinopsis = '" + clientefdtoup.Sinopsis + "', idioma = '" + clientefdtoup.Idioma + "', sonido = '" + clientefdtoup.Sonido + "', id_nacionalidad = " + clientefdtoup.id_Nacionalidad + ", id_genero = " + clientefdtoup.id_Genero + ", Estreno = '" + clientefdtoup.Estreno + "' WHERE id_Pelicula = " + clientefdtoup.id_Pelicula;
            SqlConnection con;
            con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand comando;
            comando = new SqlCommand(SQL_Update_CF, con);
            comando.ExecuteReader();
            con.Close();
        }

        public void NewPeliculasotro(PeliculasDTO new_pel_DTO)
        {
            String SQL_NewPeliculas = "insert into peliculas values ('" + new_pel_DTO.Pelicula + "',"+new_pel_DTO.id_Clasificacion+"," + new_pel_DTO.Duracion_min + ",'" + new_pel_DTO.Sinopsis +"','"+ new_pel_DTO.Idioma +"','"+new_pel_DTO.Sonido+"',"+new_pel_DTO.id_Nacionalidad+","+new_pel_DTO.id_Genero+",'" + new_pel_DTO.Estreno + "')";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL_NewPeliculas, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}