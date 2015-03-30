﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;


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

    }


}
