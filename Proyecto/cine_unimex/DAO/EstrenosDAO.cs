using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using unimex.lenguajesv.cine.DTO;
using unimex.lenguajesv.cine.DAO;


namespace unimex.lenguajesv.cine.DAO
{
    class EstrenosDAO
    {
        private String SQL_Consulta_Estrenos = "select peliculas_estrenos.id_estreno, peliculas_estrenos.fecha_estreno, peliculas_estrenos.pelicula, peliculas_estrenos.habilitado from peliculas_estrenos  inner join peliculas  on peliculas_estrenos.id_pelicula = peliculas.id_pelicula";
        private String Cadena = Properties.Resources.CADENA_CONEXION;
        public int id_estrenos;
        public int id_pelicula;

        public DataTable loadEstrenos()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_Consulta_Estrenos, con))
            {

                DataTable tbln = new DataTable();
                adapter.Fill(tbln);
                con.Close();
                return tbln;
            }

        }

        public void agregarEstrenos(EstrenosDTO n)
        {


            String SQL_Agregar_Estreno = " insert into peliculas_estrenos (id_pelicula, fecha_estreno, habilitado) values ( '" + n.Id_pelicula + "' , '" + n.Fecha_estreno + "' , '" + n.Habilitado + "')";
            SqlConnection con;
            con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand comando;
            comando = new SqlCommand(SQL_Agregar_Estreno, con);
            comando.ExecuteNonQuery();
            con.Close();


        }

        public EstrenosDTO cargarEstrenoUpdate(int id)
        {
            String SQL_Cargar_Estreno = "select * from peliculas_estrenos where id_estreno = " + id;
           EstrenosDTO na = new EstrenosDTO();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL_Cargar_Estreno, con);
            SqlDataReader red = cmd.ExecuteReader();
            while (red.Read())
            {
                na.Id_estrenos = (int)red.GetInt32(0);
                na.Id_pelicula = (int)red.GetInt32(1);
                na.Fecha_estreno = (String)red.GetString(2);
                na.Habilitado = (bool)red.GetBoolean(3);

            }
            con.Close();
            return na;
        }

        public void updateEstrenosDTO(EstrenosDTO estrenosup)
        {
            String SQL_Update_Estrenos = " UPDATE peliculas_estrenos SET id_pelicula = '" + estrenosup.Id_pelicula + "', fecha_estreno = '" + estrenosup.Fecha_estreno + "' , habilitado = '" + estrenosup.Habilitado + "' WHERE id_estrenos = " + estrenosup.Id_estrenos;
            SqlConnection con;
            con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand comando;
            comando = new SqlCommand(SQL_Update_Estrenos, con);
            comando.ExecuteNonQuery();
            con.Close();
        }

        public void borrarEstreno (EstrenosDTO borrar)
        {
            String SQL_Borrar_Estreno = " DELETE FROM peliculas_estrenos WHERE id_estreno = " + borrar.Id_estrenos;
            SqlConnection con;
            con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand comando;
            comando = new SqlCommand(SQL_Borrar_Estreno, con);
            comando.ExecuteNonQuery();
            con.Close();
        }

        public DataTable BusquedaEstreno(EstrenosDTO bus)
        {
            String SQL_Estreno = "select peliculas_estrenos.id_estreno AS Id , peliculas_estreno.fecha_estreno AS Fecha_estreno, peliculas_estrenos.habilitado AS Habilitado from peliculas_estrenos where peliculas_estrenos.id_estreno = " + bus.Id_estrenos;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            using (SqlDataAdapter adn = new SqlDataAdapter(SQL_Estreno, con))
            {

                DataTable tblpbus = new DataTable();
                adn.Fill(tblpbus);
                con.Close();
                return tblpbus;
            }
        }

        public DataTable LoadEstrenos()
        {
            String SQL_Estrenosbus = "select id_estreno, fecha_estreno from peliculas_estrenos";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_Estrenosbus, con))
            {

                DataTable tbl = new DataTable();
                adapter.Fill(tbl);
                con.Close();
                return tbl;
            }
        }

    }
}