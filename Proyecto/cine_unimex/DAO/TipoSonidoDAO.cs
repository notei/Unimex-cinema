using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using unimex.lenguajesv.cine.DTO;

namespace unimex.lenguajesv.cine.DAO
{
    class TipoSonidoDAO
    {
        private String SQL_Consulta_TipoSonido = "select cat_tipo_sonido.id_tipo_sonido AS Id , cat_tipo_sonido.tipo_sonido AS TipoSonido, cat_tipo_sonido.descripcion AS Descripcion, cat_tipo_sonido.habilitado AS Habilitado FROM cat_tipo_sonido";
        private String Cadena = Properties.Resources.CADENA_CONEXION;

        public DataTable loadTipoSonido()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_Consulta_TipoSonido, con))
            {
                DataTable tbltts = new DataTable();
                adapter.Fill(tbltts);
                con.Close();
                return tbltts;
            }
        }
        public void agregarTipoSonido(TipoSonidoDTO proytidto)
        {
            String SQL_Agregar_TS = " insert into cat_tipo_sonido (tipo_sonido, descripcion, habilitado) values ( '" + proytidto.tipoSonido + "' , '" + proytidto.Descripcion + "', '" + proytidto.Habilitado + "')";
            SqlConnection con;
            con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand comando;
            comando = new SqlCommand(SQL_Agregar_TS, con);
            comando.ExecuteNonQuery();
            con.Close();
        }
        public TipoSonidoDTO cargarTSonidoUpdate(int id)
        {
            String SQL_Cargar_Tiposonido = "select * from cat_tipo_sonido where id_tipo_sonido = " + id;
            TipoSonidoDTO TSdto = new TipoSonidoDTO();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL_Cargar_Tiposonido, con);
            SqlDataReader red = cmd.ExecuteReader();
            while (red.Read())
            {
                TSdto.id_TipoSonido = (int)red.GetInt32(0);
                TSdto.tipoSonido = (String)red.GetString(1);
                TSdto.Descripcion = (String)red.GetString(2);
                TSdto.Habilitado = (Boolean)red.GetBoolean(3);
            }
            con.Close();
            return TSdto;
        }
        public void updateTipoSonidoDTO(TipoSonidoDTO TPdtoup)
        {
            String SQL_Update_TP = " UPDATE cat_tipo_sonido SET tipo_sonido = '" + TPdtoup.tipoSonido + "', descripcion = '" + TPdtoup.Descripcion + "', habilitado = '" + TPdtoup.Habilitado + "' WHERE id_tipo_sonido = " + TPdtoup.id_TipoSonido;
            SqlConnection con;
            con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand comando;
            comando = new SqlCommand(SQL_Update_TP, con);
            comando.ExecuteNonQuery();
            con.Close();
        }
        public void deleteTsonidoDTO(TipoSonidoDTO deletedtotp)
        {
            String SQL_Update_TS = " DELETE FROM cat_tipo_sonido WHERE id_tipo_sonido = " + deletedtotp.id_TipoSonido;
            SqlConnection con;
            con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand comando;
            comando = new SqlCommand(SQL_Update_TS, con);
            comando.ExecuteNonQuery();
            con.Close();
        }
    }
}
