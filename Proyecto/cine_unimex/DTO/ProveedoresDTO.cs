using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//DAO realizado por Gonzalez Reyes Berenice Izamar

namespace unimex.lenguajesv.cine.DTO
{
    class ProveedoresDTO
    {
        private int id_proveedor;
        private string proveedor;
        private string detalles;
        private Boolean habilitado;


        public int idproveedor
        {
            get {return id_proveedor; }
            set { id_proveedor = value; }
        }

        public string proveedores
        {
            get { return proveedor; }
            set { proveedor = value; }

        }

        public string detalle
        {
            get { return detalles; }
            set { detalles = value; }

        }

        public Boolean Habilitado
        {
            get { return habilitado; }
            set { habilitado = value; }
        }

    }
}
