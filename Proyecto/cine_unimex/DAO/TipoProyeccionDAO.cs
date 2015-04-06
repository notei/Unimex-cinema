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
    }
}
