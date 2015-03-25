using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace unimex.lenguajesv.cine.DAO
{
    class ProyeccionesDAO
    {

        private String SQL_Consulta_Proyecciones = "select proyecciones.id_proyeccion AS Id , cat_salas_complejos.nombre_sala AS Sala, peliculas.pelicula AS Película, convert (varchar,proyecciones.horario,100)as Horario from proyecciones inner join cat_salas_complejos on proyecciones.id_sala = cat_salas_complejos.id_sala inner join peliculas on peliculas.id_pelicula = proyecciones.id_pelicula";
        private String Cadena = Properties.Resources.CADENA_CONEXION;

        public DataTable LoadProyecciones()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_Consulta_Proyecciones, con))
            {

                DataTable tbl = new DataTable(); 
                adapter.Fill(tbl);
                return tbl;
            }



        }


    }
}
