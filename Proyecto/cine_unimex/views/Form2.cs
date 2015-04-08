using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using unimex.lenguajesv.cine.DAO;

namespace unimex.lenguajesv.cine.views
{
    public partial class Form2 : Form
    {
        //decalaramos variables globales

        Matematicas mate;

        public Form2()
        {
            InitializeComponent();
            mate = new Matematicas(this);

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        public void actualizarResultado(String valor)
        {
            //actualiza el valor dentro de la caja de texto
            resultado.Text = valor;


        }

        private void sumabtn_Click(object sender, EventArgs e)
        {
            // se leen los valores ingresados 
            int a = (int)operando1txt.Value;
            int b = (int)operando2txt.Value;
            int c = (int)operando3txt.Value;
            int d = (int)operando4txt.Value;

            //ejecuta el metodo sumar dela clase matematicas, el cual desarrolla la operacion 
            mate.sumar(a, b, c, d);
        }

        private void resultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
