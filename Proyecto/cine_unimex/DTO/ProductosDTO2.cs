using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace unimex.lenguajesv.cine.DTO
{
    class ProductosDTO2
    {
        private int id_produto;
        private int nombre;
        private int descripcion;
        private int precio;
        private int disponibilidad;
        private int id_tipo_producto;
        private int id_proveedor;

        public int idproducto
        {

            get { return id_produto; }


            set { id_produto = value; }
        }

        public int Nombre
        {

            get { return Nombre; }


            set { nombre = value; }
        }

        public int Descripcion
        {

            get { return Descripcion; }


            set { descripcion = value; }
        }

        public int Precio
        {

            get { return precio; }


            set { precio = value; }
        }
        public int Disponibilidad
        {

            get { return Disponibilidad; }


            set { precio = value; }
        }



        public int Id_tipo_producto
        {

            get { return Id_tipo_producto; }


            set { id_tipo_producto = value; }
        }

        public int Id_proveedor
        {

            get { return Id_proveedor; }


            set { id_proveedor = value; }
        }

    
    }
}
