using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace unimex.lenguajesv.cine.DTO
{
    class ReportesDTO
    {

        private int id_registro_ventas;
        private DateTime fecha;
        private int id_complejo;
        private int id_tipo_pago;

        public int Idregistro
        {
            get { return id_registro_ventas; }
            set { id_registro_ventas = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public int Idcomplejo
        {
            get { return id_complejo; }
            set{ id_complejo = value;}
        }

        public int Idtipopago
        {
            get { return id_tipo_pago; }
            set { id_tipo_pago = value; }
        }
    }
}
