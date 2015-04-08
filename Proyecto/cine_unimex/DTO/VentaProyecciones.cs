using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace unimex.lenguajesv.cine.DTO
{
    class VentaProyecciones
    {



        private int id_venta_proy;
        private int id_proyeccion;
        private int cantidadB;
        private int id_precio;
        private int id_cliente_frecuente;
        private int num_transacción;
        private float precio_nuitario;
        private float precio_total;
        private int registro_venta;

        public int Idventa
        {
            get { return id_venta_proy; }
            set { id_venta_proy = value; }
        }

        public int IdProyeccion
        {
            get { return id_venta_proy; }
            set { id_venta_proy = value; }
        }
        public int Cantidad
        {
            get { return cantidadB; }
            set { cantidadB = value; }
        }
        public int Idprecio
        {
            get { return id_precio; }
            set { id_precio = value; }
        }
        public int IdCliente
        {
            get { return id_cliente_frecuente; }
            set { id_cliente_frecuente = value; }
        }
        public int NumTransación
        {
            get { return num_transacción; }
            set { num_transacción = value; }
        }
        public float PrecioU
        {
            get { return precio_nuitario; }
            set { precio_nuitario = value; }
        }

        public float Total
        {
            get { return precio_total; }
            set { precio_total = value; }
        }
        public int IdRegistro
        {
            get { return registro_venta; }
            set {  registro_venta = value;}
        }
        


    }

}







