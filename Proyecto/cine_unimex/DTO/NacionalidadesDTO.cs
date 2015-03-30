using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace unimex.lenguajesv.cine.DTO
{
    class NacionalidadesDTO
    {

        private int id_nacionalidad;
        private String nacionalidad;
        private bool habilitado;

        public int id_Nacionalidad
        {
       
            get { return id_nacionalidad; }
          
            set { id_nacionalidad = value; }

        }

        public String Nacionalidad
        {
            get { return nacionalidad; }

            set { nacionalidad = value; }
        }

        public bool Habilitado
        {
            get { return habilitado; }

            set { habilitado = value; }
        }

    }
}
