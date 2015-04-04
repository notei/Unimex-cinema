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
            String SQL_NewCortos = "insert into cat_cortos values ('" + new_Cortos_DTO.Id_Corto + "','" + new_Cortos_DTO.Nombre_Corto + "','" + new_Cortos_DTO.Duracion + "', '" + new_Cortos_DTO.Habilitado + "')";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL_NewCortos, con);
            cmd.ExecuteNonQuery();
            con.Close();






        }
    }
}
