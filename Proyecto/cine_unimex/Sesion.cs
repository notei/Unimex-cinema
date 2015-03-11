using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace unimex.lenguajesv.cine
{
    public class Sesion
    {

        public static Hashtable data = new Hashtable();


        public static Object getElement(String nombre)
        {
            return data[nombre];
        }

        public static void addElement(String name, Object obj)
        {
            data.Add(name, obj);
        }
    }
}
