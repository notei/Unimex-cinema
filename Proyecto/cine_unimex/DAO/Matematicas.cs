using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using unimex.lenguajesv.cine.views;

namespace unimex.lenguajesv.cine.DAO
{
    class Matematicas
    {
        //variables globales
        Form2 forma;


        public Matematicas(Form2 f)
        {
            //asigna el valor de f a la variable global 
            forma = f;
        }


        public void sumar(int a, int b, int c, int d)
        {
            int r = a + b + c + d; ; //realiza la suma de efectivo


            forma.actualizarResultado(r + "");

        }

    }
}