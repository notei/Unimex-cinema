using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using unimex.lenguajesv.cine.DTO;


namespace unimex.lenguajesv.cine.DAO
{
    class peliculas_estrenosDAO
    {
        
        private String selectsql = "select peliculas_estrenos.id_estreno,peliculas_estrenos.fecha_estreno,peliculas.pelicula,peliculas_estrenos.habilitado from peliculas_estrenos  inner join peliculas on peliculas_estrenos.id_pelicula = peliculas.id_pelicula";
        private String cadenacon = "Data Source=benny;Initial Catalog=unimex_cinema_db;Integrated Security=True";

        public DataTable cargardatos()
        {
            SqlConnection conx = null;
            conx = new SqlConnection();

            conx.ConnectionString = cadenacon;
            conx.Open();
            using (SqlDataAdapter adaptador = new SqlDataAdapter(selectsql, conx))
            {
                DataTable t = new DataTable();
                adaptador.Fill(t);
                return t;

            }

        }
        public void insertaestrenos(peliculas_estrenosDTO p)
        {
            String sql = "INSERT INTO películas_estrenos(id_estrenos,id_peliculas,fecha_estreno,habilitado) value('" + p.Id_estreno + "," + p.Pelicula + "," + p.Fecha_estreno + "," + p.Habilitado + ")";
           

            SqlConnection conx = null;
            conx = new SqlConnection();

            conx.ConnectionString = cadenacon;
            conx.Open();
            SqlCommand comando;
            comando = new SqlCommand(sql, conx);
            comando.ExecuteNonQuery();
            conx.Close();

        }
        public void modificar(peliculas_estrenosDTO q)
        {
           

        }
    }
}

   