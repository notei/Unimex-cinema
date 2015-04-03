using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace unimex.lenguajesv.cine.DTO
{
    class TipoProyeccionDTO
    {
        private int id_tipo_proyeccion;
        private String tipo_proyeccion;
        private String descripcion;
        private bool habilitado;

        public int id_TipoProyeccion
        {

            get { return id_tipo_proyeccion; }

            set { id_tipo_proyeccion = value; }

        }

        public String tipoProyeccion
        {
            get { return tipo_proyeccion; }

            set { tipo_proyeccion = value; }
        }

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }

        }

        public bool Habilitado
        {
            get { return habilitado; }

            set { habilitado = value; }
        }
    }
}
