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
            String SQL_NewSalas = "insert into cat_salas_complejos values (" + new_salas_DTO.Id_Complejo + ",'" + new_salas_DTO.Nombre_Sala + "'," + new_salas_DTO.Capacidad + ",'" + new_salas_DTO.Butacas_Numeradas + "'," + new_salas_DTO.Id_Tipo_Sonido + "," + new_salas_DTO.Id_Tipo_Proyeccion + ")";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL_NewSalas, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public SalasDTO LoadSalas1(int id)
        {
            String SQL_Conocer_Salas = "select * from cat_salas_complejos where id_sala =" + id;
            SalasDTO sal_dto = new SalasDTO();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL_Conocer_Salas, con);
            SqlDataReader red = cmd.ExecuteReader();
            while (red.Read())
            {
                sal_dto.Id_Sala = (int)red.GetSqlInt32(0);
                sal_dto.Id_Complejo = (int)red.GetSqlInt32(1);
                sal_dto.Nombre_Sala = (String)red.GetSqlString(2);
                sal_dto.Capacidad = (int)red.GetSqlInt32(3);
                sal_dto.Butacas_Numeradas = (Boolean)red.GetSqlBoolean(4);
                sal_dto.Id_Tipo_Sonido = (int)red.GetSqlInt32(5);
                sal_dto.Id_Tipo_Proyeccion = (int)red.GetSqlInt32(6);
            }
            return sal_dto;


        }
        public void upDataSalas(SalasDTO updata_Salas)
        {
            String SQL_Updata_Salas = "update cat_salas_complejos set id_complejo = " + updata_Salas.Id_Complejo + ", nombre_sala = '" + updata_Salas.Nombre_Sala + "', capacidad = " + updata_Salas.Capacidad + " , butacas_numeradas ='" + updata_Salas.Butacas_Numeradas + "',id_tipo_sonido = " + updata_Salas.Id_Tipo_Sonido + ", id_tipo_proyeccion = " + updata_Salas.Id_Tipo_Proyeccion + " WHERE id_sala = " + updata_Salas.Id_Sala;
            SqlConnection con;
            con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand comando;
            comando = new SqlCommand(SQL_Updata_Salas, con);
            comando.ExecuteNonQuery();
            con.Close();

        }


    }

    
}
