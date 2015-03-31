using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace unimex.lenguajesv.cine.DTO
{
    class ProductosDTO
    {
        private int id_tipo_producto;
        private string nombre;
        private string descripcion;
        private bool habilitado;

        public int IdTipoProducto
         {
             get { return id_tipo_producto; }
             set { id_tipo_producto = value; }

         }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public bool Habilitar
        {
            get { return habilitado; }
            set { habilitado = value; }
        }
    }
}
