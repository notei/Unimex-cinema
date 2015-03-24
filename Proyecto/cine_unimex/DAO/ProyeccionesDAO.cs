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
        private String SQL_CONPROYECCIONES = "select proyecciones.id_proyeccion, cat_salas_complejos.nombre_sala, peliculas.pelicula, convert (varchar,proyecciones.horario,100)as Hora from  proyecciones inner join cat_salas_complejos on proyecciones.id_sala = cat_salas_complejos.id_sala inner join peliculas on peliculas.id_pelicula = proyecciones.id_pelicula";
        private String cadena = "Data Source=LOCALHOST;Initial Catalog=unimex_cinema_db;Integrated Security=true";

       public DataTable LoadProyecciones()
        {
            
           SqlConnection con = new SqlConnection();
            con.ConnectionString = cadena;
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_CONPROYECCIONES, con))
            {
                DataTable tbl = new DataTable();
                adapter.Fill(tbl);
                return tbl;
            }



        }

    }
}
