using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using unimex.lenguajesv.cine.DTO;

namespace unimex.lenguajesv.cine.DAO
{
    class CortosDAO
    {

        private String consulta_Cortos = "select cat_cortos.id_corto, peliculas.pelicula, cat_cortos.nombre_corto,cat_cortos.duracion, cat_cortos.habilitado from peliculas inner join cat_cortos on cat_cortos.id_pelicula = peliculas.id_pelicula";
        private String Cadena = Properties.Resources.CADENA_CONEXION;
  

        public DataTable loadCortos()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(consulta_Cortos, con))
            {

                DataTable tblp = new DataTable();
                adapter.Fill(tblp);
                con.Close();
                return tblp;
            }

        }

        public void newCortos(CortosDTO new_Cortos_DTO)
        {
            String SQL_NewCortos = "insert into cat_cortos values (" + new_Cortos_DTO.Id_Pelicula + ",'" + new_Cortos_DTO.Nombre_Corto + "'," + new_Cortos_DTO.Duracion + ",'" + new_Cortos_DTO.Habilitado + "')";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL_NewCortos, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public void updateCortos(CortosDTO update_cortos)
        {

            String SQL_updatecortos = "update cat_cortos set  id_pelicula = " + update_cortos.Id_Pelicula + " , nombre_corto =' " + update_cortos.Nombre_Corto + "' , duracion = " + update_cortos.Duracion + "  , habilitado = '" + update_cortos.Habilitado + "'   where id_corto = " + update_cortos.Id_Corto;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL_updatecortos, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public CortosDTO LoadCortos(int id)
        {
            String SQL_Connocer_Corto = "select * from cat_cortos where id_corto = " + id;
            CortosDTO cortos_dto = new CortosDTO();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL_Connocer_Corto, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                cortos_dto.Id_Corto = (int)rd.GetSqlInt32(0);
                cortos_dto.Id_Pelicula = (int)rd.GetSqlInt32(1);
                cortos_dto.Nombre_Corto = (string)rd.GetSqlString(2);
                cortos_dto.Duracion = (int)rd.GetSqlInt32(3);
                cortos_dto.Habilitado = (bool)rd.GetBoolean(4);

            }
            con.Close();
            return cortos_dto;


        }
        public void borrar(CortosDTO borrar_cortos)
        {
            String SQL_Updata_Corto = "update cat_cortos set habilitado =  ";
            SqlConnection con;
            con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand comando;
            comando = new SqlCommand(SQL_Updata_Corto, con);
            comando.ExecuteNonQuery();
            con.Close();
        }
    }
}
