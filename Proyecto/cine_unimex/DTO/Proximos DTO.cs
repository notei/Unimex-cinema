using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace unimex.lenguajesv.cine.DTO
{
    class Proximos_DTO
    {
        private int id_estreno;
        private int id_pelicula;
        private DateTime fecha_estreno;
        private Boolean habilitado;

        public int Id_estreno
        {
            get { return id_estreno; }
            set { id_estreno = value; }
        }
        public int Id_pelicula
        {
            get { return id_pelicula; }
            set { id_pelicula = value; }
        }
        public DateTime Fecha_estreno
        {
            get { return fecha_estreno; }
            set { fecha_estreno = value; }
        }
        public Boolean Habilitado
        {
            get { return habilitado; }
            set { habilitado = value; }
        }
    }
}
