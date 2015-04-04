using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using unimex.lenguajesv.cine.DTO;

namespace unimex.lenguajesv.cine
{
    class ActoresDAO
    {
        private String consulta_Actores = "SELECT * FROM cat_actores";
        private String Cadena = Properties.Resources.CADENA_CONEXION;

        public DataTable loadActores()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(consulta_Actores, con))
            {

                DataTable tblp = new DataTable();
                adapter.Fill(tblp);
                con.Close();
                return tblp;
            }

        }

        public void Actoragregar(ActoresDTO a)
        {

            String agregar = " insert into cat_actores (nombre,apellido_paterno, apellido_materno, sexo, id_nacionalidad) values ( '" + a.Nombre + "' , '" + a.ApellidoP + "' , '" + a.ApellidoM + "'," + a.Sexo + "," + a.Id_Nacionalidad + ")";

          

            SqlConnection con;
            con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();

            SqlCommand comando;
            comando = new SqlCommand(agregar, con);
            comando.ExecuteNonQuery();
            con.Close();

        }

       public void ActorNacionalidad(NacionalidadesActoresDTO n)
        {

          String agregar = " insert into cat_nacionalidades (nacionalidad) values ( '" + n.Nacionalidad + "')";



            SqlConnection con;
             con = new SqlConnection();
             con.ConnectionString = Cadena;
             con.Open();

               SqlCommand comando;
               comando = new SqlCommand(agregar, con);
               comando.ExecuteNonQuery();
              con.Close();

          }

        public DataTable nacionalidadescbx()
        {
            String cbxNacionalidad = "select nacionalidad from nacionalidades";
            SqlConnection con = getConexion();
            using (SqlDataAdapter adapter = new SqlDataAdapter(cbxNacionalidad, con))
            {

                DataTable tbl = new DataTable();
                adapter.Fill(tbl);
                con.Close();
                return tbl;
            }
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
