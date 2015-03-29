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
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
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

            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL_NewProyeccion, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }


    }
}
