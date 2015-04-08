using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace unimex.lenguajesv.cine.DTO
{
    class ProductosCombosDTO
    {
        //Declaracion de variables
        private int id_combo;
        private String nombre;
        private String descripcion;
        private int precio;
        private Boolean habilitado;



        public int Id_Combo
        {
            //Obtiene un valor 
            get
            {
                return id_combo;
            }
            //Pone o da un valor 
            set
            {
                id_combo = value;
            }
        }
        public String Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public String Descripcion
        {
            get
            {
                return descripcion;
            }
            set
            {
                descripcion = value;
            }

        }
        public int Precio
        {
            get
            {
                return precio;
            }
            set
            {
                precio = value;
            }
        }
        public Boolean Habilitado
        {
            get
            {
                return habilitado;
            }
            set
            {
                habilitado = value;
            }
        }
    }
}
