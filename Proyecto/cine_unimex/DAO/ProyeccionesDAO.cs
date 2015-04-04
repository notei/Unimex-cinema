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

        
        private String Cadena = Properties.Resources.CADENA_CONEXION;
        //private String Cadena = "Data Source=LOCALHOST;Initial Catalog=unimex_cinema_db;Integrated Security=true";
        public DataTable LoadProyecciones()
        {
            String SQL_Consulta_Proyecciones = "select proyecciones.id_proyeccion AS Id , cat_salas_complejos.nombre_sala AS Sala, peliculas.pelicula AS Película, convert (varchar,proyecciones.horario,100)as Horario from proyecciones inner join cat_salas_complejos on proyecciones.id_sala = cat_salas_complejos.id_sala inner join peliculas on peliculas.id_pelicula = proyecciones.id_pelicula";
            SqlConnection con = getConexion();
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_Consulta_Proyecciones, con))
            {

                DataTable tbl = new DataTable(); 
                adapter.Fill(tbl);
                con.Close();
                return tbl;
            }

        }

        public DataTable findPeliculas(ProyeccionesDTO BuscarDTO)
        {
            String SQL_FindPeliculas = "select proyecciones.id_proyeccion AS Id , cat_salas_complejos.nombre_sala AS Sala, peliculas.pelicula AS Película, convert (varchar,proyecciones.horario,100)as Horario from proyecciones inner join cat_salas_complejos on proyecciones.id_sala = cat_salas_complejos.id_sala inner join peliculas on peliculas.id_pelicula = proyecciones.id_pelicula Where proyecciones.id_pelicula = " + BuscarDTO.idpelicula;
            SqlConnection con = getConexion();
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_FindPeliculas, con))
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
         public void updateProyeccion (ProyeccionesDTO update_proy)
        {
            String SQL_UpdateProyeccion = "UPDATE proyecciones SET id_sala = " + update_proy.idsala + "  , id_pelicula = "+ update_proy.idpelicula +", horario = convert(datetime,'"+ update_proy.fechas +"',102) WHERE id_proyeccion = "+ update_proy.idproyeccion;
            SqlConnection con = getConexion();
            SqlCommand cmd = new SqlCommand(SQL_UpdateProyeccion, con);
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
        public ProyeccionesDTO LoadProyecciones(int id)
        {
            String SQL_Conocer_Proyección = "select * from proyecciones where id_proyeccion = " + id ;
            ProyeccionesDTO proy_dto = new ProyeccionesDTO();
            SqlConnection con = getConexion();
            SqlCommand cmd = new SqlCommand(SQL_Conocer_Proyección, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                proy_dto.idproyeccion = (int)rd.GetSqlInt32(0);
                proy_dto.idsala = (int)rd.GetInt32(1);
                proy_dto.idpelicula = (int)rd.GetInt32(2);
                proy_dto.fechasDT = (DateTime)rd.GetSqlDateTime(3);
            }

            return proy_dto; 
        }
        public ProyeccionesDTO LoadComplejoBySalas(int Idsala)
        {
            String SQL_Consulta_Salas = "select id_complejo from cat_salas_complejos where id_sala= " + Idsala;
            SqlConnection con = getConexion();
            ProyeccionesDTO proy_dto = new ProyeccionesDTO();
            SqlCommand cmd = new SqlCommand(SQL_Consulta_Salas, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            
            {
                proy_dto.idcomplejo = (int)rd.GetInt32(0);
            }
            return proy_dto;
        }
        private SqlConnection getConexion()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            return con;
        }
    }
}
