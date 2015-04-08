using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace unimex.lenguajesv.cine.DTO
{
    class ReporteVentas
    {
        private int id_registro_venta;
        private DateTime fecha_venta;
        private int id_complejo;
        private int id_tipo_pago;

        public int Idregistro
        {
            get { return Idregistro; }
            set { Idregistro = value; }
        }


        public DateTime fecha
        {

            get { return fecha_venta; }
            set { fecha_venta = value; }
        }

        public int IdComplejo
        {
            get { return id_complejo; }
            set { id_complejo = value; }
        }

        public int IdPago
        {
            get { return id_tipo_pago; }
            set { id_tipo_pago = value; }
        }
    }
}



