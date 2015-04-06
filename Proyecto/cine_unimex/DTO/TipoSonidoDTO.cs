using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace unimex.lenguajesv.cine.DTO
{
    class TipoSonidoDTO
    {
        private int id_tipo_sonido;
        private String tipo_sonido;
        private String descripcion;
        private bool habilitado;

        public int id_TipoSonido
        {

            get { return id_tipo_sonido; }

            set { id_tipo_sonido = value; }

        }

        public String tipoSonido
        {
            get { return tipo_sonido; }

            set { tipo_sonido = value; }
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
