using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace unimex.lenguajesv.cine.DTO
{
    class ProductosDTO2
    {

        private int id_produto; //verifica tus tipos de datos no todos son enteros
        private int nombre; // por ejemplo este debe ser String
        private int descripcion; //si tu campo en SQL te indica varchar o char pasalo a String
        private int precio; //Nota: borra estas lineas cuando corrijas los errores 
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

            get { return nombre; }


            set { nombre = value; }
        }

        public int Descripcion
        {

            get { return descripcion; }


            set { descripcion = value; }
        }

        public int Precio
        {

            get { return precio; }


            set { precio = value; }
        }
        public int Disponibilidad
        {

            get { return disponibilidad; }


            set { disponibilidad = value; }
        }



        public int Id_tipo_producto
        {

            get { return id_tipo_producto; }


            set { id_tipo_producto = value; }
        }

        public int Id_proveedor
        {

            get { return id_proveedor; }


            set { id_proveedor = value; }
        }

    
    }
}
