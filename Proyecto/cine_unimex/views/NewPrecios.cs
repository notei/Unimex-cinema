using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using unimex.lenguajesv.cine.DAO;
using unimex.lenguajesv.cine.DTO;

namespace unimex.lenguajesv.cine.views
{
    public partial class NewPrecios : Form
    {
        public NewPrecios()
        {
            InitializeComponent();
        }

        private void btnAgregarnew_Click(object sender, EventArgs e)
        {
            if (txtNombrenew.Text != "" && txtDescnew.Text !="" && txtPrecionew.Text !="")
            {
                PreciosDTO pdto = new PreciosDTO();
                pdto.Nombre = txtNombrenew.Text;
                pdto.Descripcion = txtDescnew.Text;
                pdto.Precios = Int32.Parse(txtPrecionew.Text);
                try
                {
                    PreciosDAO daoprecio = new PreciosDAO();
                    daoprecio.agregarPrecio(pdto);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
            else
            {
                MessageBox.Show("Ingresa Nombre, Descripcion y precio para poder guardar el registro!!!");
            }
            this.Dispose();
        }

        private void btnCancelarnew_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
