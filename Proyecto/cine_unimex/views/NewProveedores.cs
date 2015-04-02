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
    public partial class NewProveedores : Form
    {
        public NewProveedores()
        {
            InitializeComponent();
        }

        private void NewProveedores_Load(object sender, EventArgs e)
        {

        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (txtnamepro.Text != "")
            {
                ProveedoresDTO  n = new ProveedoresDTO ();
                n.proveedores = txtnamepro.Text ;
                n.detalle = txtdetallespro.Text;
                n.Habilitado = checkpro.Checked;


                try
                {
                    ProveedoresDAO  dao = new ProveedoresDAO ();
                    dao.agregarProveedor(n);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }

            }

            else
            {
                MessageBox.Show(" Ingrese un Proveedor ", " ERROR");
            }
            this.Dispose();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}


