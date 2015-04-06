using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using unimex.lenguajesv.cine.DTO;


namespace unimex.lenguajesv.cine
{
    class NacionalidadesDAO
    {
        private String SQL_Consulta_Nacionalidades = "select nacionalidades.id_nacionalidad AS Id , nacionalidades.nacionalidad AS Nacionalidad, nacionalidades.habilitado AS Habilitado FROM nacionalidades";
        private String Cadena = Properties.Resources.CADENA_CONEXION;


        public DataTable loadNacionalidades()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_Consulta_Nacionalidades, con))
            {

                DataTable tbln = new DataTable();
                adapter.Fill(tbln);
                con.Close();
                return tbln;
            }

        }

        public void agregarNacionalidad( NacionalidadesDTO n )
       
        {
            

           String SQL_Agregar_Nacionalidad = " insert into nacionalidades (nacionalidad, habilitado) values ( '" + n.Nacionalidad + "' , '"+ n.Habilitado +"')";

           

           SqlConnection con;
           con = new SqlConnection();
           con.ConnectionString = Cadena;
           con.Open();
           SqlCommand comando;
           comando = new SqlCommand(SQL_Agregar_Nacionalidad, con);
           comando.ExecuteNonQuery();
           con.Close();

        
        }

        public NacionalidadesDTO cargarNacionalidadUpdate(int id)
        {
            String SQL_Cargar_nacionalidad = "select * from nacionalidades where id_nacionalidad = " + id;
            NacionalidadesDTO na = new NacionalidadesDTO();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL_Cargar_nacionalidad, con);
            SqlDataReader red = cmd.ExecuteReader();
            while (red.Read())
            {
                na.id_Nacionalidad = (int)red.GetInt32(0);
                na.Nacionalidad = (String)red.GetString(1);
                na.Habilitado = (bool)red.GetBoolean(2);
               
            }
            con.Close();
            return na;
        }

        public void updateNacionalidadesDTO(NacionalidadesDTO nacionalidadup)
        {
            String SQL_Update_Nacionalidad = " UPDATE nacionalidades SET nacionalidad = '" + nacionalidadup.Nacionalidad + "', habilitado = '" + nacionalidadup.Habilitado + "' WHERE id_nacionalidad = " + nacionalidadup.id_Nacionalidad;
            SqlConnection con;
            con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand comando;
            comando = new SqlCommand(SQL_Update_Nacionalidad, con);
            comando.ExecuteNonQuery();
            con.Close();
        }
    }

}
