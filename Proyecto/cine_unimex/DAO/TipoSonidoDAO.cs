﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

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

    }
}
