using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using unimex.lenguajesv.cine.DTO;

namespace unimex.lenguajesv.cine.DAO
{
    class TipoProyeccionDAO
    {

        private String SQL_Consulta_TipoProyeccion = "select cat_tipo_proyeccion.id_tipo_proyeccion AS Id , cat_tipo_proyeccion.tipo_proyeccion AS TipoProyeccion, cat_tipo_proyeccion.descripcion AS Descripcion, cat_tipo_proyeccion.habilitado AS Habilitado FROM cat_tipo_proyeccion";
        private String Cadena = Properties.Resources.CADENA_CONEXION;


        public DataTable loadTipoProyeccion()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_Consulta_TipoProyeccion, con))
            {

                DataTable tbltp = new DataTable();
                adapter.Fill(tbltp);
                con.Close();
                return tbltp;
            }

        }

        public void agregarTipoproyeccion (TipoProyeccionDTO proytidto)
        {
            String SQL_Agregar_TP = " insert into cat_tipo_proyeccion (tipo_proyeccion, descripcion, habilitado) values ( '" + proytidto.tipoProyeccion + "' , '" + proytidto.Descripcion + "', '" + proytidto.Habilitado + "')";
            SqlConnection con;
            con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand comando;
            comando = new SqlCommand(SQL_Agregar_TP, con);
            comando.ExecuteNonQuery();
            con.Close();
        }
        public TipoProyeccionDTO cargarTPUpdate (int id)
        {
            String SQL_Cargar_TipoP = "select * from cat_tipo_proyeccion where id_tipo_proyeccion = " + id;
            TipoProyeccionDTO TPdto = new TipoProyeccionDTO();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL_Cargar_TipoP, con);
            SqlDataReader red = cmd.ExecuteReader();
            while (red.Read())
            {
                TPdto.id_TipoProyeccion = (int)red.GetInt32(0);
                TPdto.tipoProyeccion = (String)red.GetString(1);
                TPdto.Descripcion = (String)red.GetString(2);
                TPdto.Habilitado = (Boolean)red.GetBoolean(3);
            }
            con.Close();
            return TPdto;
        }
        public void updateTipoProyeccionDTO (TipoProyeccionDTO TPdtoup)
        {
            String SQL_Update_TP = " UPDATE cat_tipo_proyeccion SET tipo_proyeccion = '" + TPdtoup.tipoProyeccion + "', descripcion = '" + TPdtoup.Descripcion + "', habilitado = '" + TPdtoup.Habilitado + "' WHERE id_tipo_proyeccion = " + TPdtoup.id_TipoProyeccion;
            SqlConnection con;
            con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand comando;
            comando = new SqlCommand(SQL_Update_TP, con);
            comando.ExecuteNonQuery();
            con.Close();
        }
    }
}
