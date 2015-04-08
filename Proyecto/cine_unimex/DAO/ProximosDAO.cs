using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace unimex.lenguajesv.cine.DAO
{
    class ProximosDAO
    {
        private String consulta_Proximo = "select peliculas_estrenos.id_estreno, peliculas.pelicula, peliculas_estrenos.fecha_estreno as Fecha from peliculas_estrenos  inner join peliculas on peliculas_estrenos.id_pelicula = peliculas.id_pelicula where peliculas_estrenos.fecha_estreno > getdate()";
        private String Cadena = Properties.Resources.CADENA_CONEXION;
    }
}
