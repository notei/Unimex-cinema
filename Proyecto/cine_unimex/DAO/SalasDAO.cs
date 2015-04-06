using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using unimex.lenguajesv.cine.DTO;

namespace unimex.lenguajesv.cine.DAO
{
    class SalasDAO
    {
        private String consulta_Salas = "select cat_salas_complejos.id_sala, cat_complejos.nombre, cat_salas_complejos.nombre_sala, cat_salas_complejos.capacidad, cat_salas_complejos.butacas_numeradas, cat_tipo_sonido.tipo_sonido, cat_tipo_proyeccion.tipo_proyeccion from cat_salas_complejos inner join cat_complejos on cat_salas_complejos.id_complejo = cat_complejos.id_complejo inner join cat_tipo_sonido on cat_tipo_sonido.id_tipo_sonido = cat_salas_complejos.id_tipo_sonido inner join cat_tipo_proyeccion on cat_tipo_proyeccion.id_tipo_proyeccion = cat_salas_complejos.id_tipo_proyeccion";
        private String Cadena = Properties.Resources.CADENA_CONEXION;

        public DataTable loadSalas()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(consulta_Salas, con))
            {

                DataTable tblp = new DataTable();
                adapter.Fill(tblp);
                con.Close();
                return tblp;
            }

        }
        public DataTable loadSonido()
        {
            String consultaSonido = "select id_tipo_sonido, tipo_sonido from cat_tipo_sonido";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(consultaSonido, con))
            {

                DataTable tblp = new DataTable();
                adapter.Fill(tblp);
                con.Close();
                return tblp;
            }

        }
        public DataTable loadProyeccion()
        {
            String consultaProyeccion = "select id_tipo_proyeccion, tipo_proyeccion from cat_tipo_proyeccion";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(consultaProyeccion, con))
            {

                DataTable tblp = new DataTable();
                adapter.Fill(tblp);
                con.Close();
                return tblp;
            }


        }
        public void newSalas(SalasDTO new_salas_DTO)
        {
            String SQL_NewSalas = "insert into cat_salas_complejos values (" +new_salas_DTO.Id_Complejo +",'" + new_salas_DTO.Nombre_Sala + "'," + new_salas_DTO.Capacidad +","+ new_salas_DTO.Butacas_Numeradas+","+ new_salas_DTO.Id_Tipo_Sonido+","+new_salas_DTO.Id_Tipo_Proyeccion+")";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL_NewSalas, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
    
}
