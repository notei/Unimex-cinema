using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using unimex.lenguajesv.cine.DTO;
using unimex.lenguajesv.cine.DAO;


namespace unimex.lenguajesv.cine.views
{
    public partial class NewProductos : Form
    {
        public NewProductos()
        {
            InitializeComponent();
        }
        private void NewProductos_Load(object sender, EventArgs e)
        {
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
           
                ProductosDTO n = new ProductosDTO();
                if (txtnombre.Text != "")
            {

                
                n.Nombre = txtnombre.Text;
                n.Descripcion  = txtdescripcion.Text;
                n.Habilitar = btncheck.Checked;


             

              



                try
                {
                    ProductosDAO dao = new ProductosDAO();

                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }

            }


            else
            {
                MessageBox.Show(" Agregue un producto ");
            }
            this.Dispose();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}

       

        

      
        




        

     
            
        

    


