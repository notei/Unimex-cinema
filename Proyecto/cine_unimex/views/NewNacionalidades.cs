using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using unimex.lenguajesv.cine.DTO;

namespace unimex.lenguajesv.cine.views
{
    public partial class NewNacionalidades : Form
    {
        public NewNacionalidades()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNewNacionalidad.Text != "")
            {
                NacionalidadesDTO n = new NacionalidadesDTO();
                n.Nacionalidad = txtNewNacionalidad.Text;
                n.Habilitado = chkHabilitado.Checked;

             
                try
                {
                    NacionalidadesDAO dao = new NacionalidadesDAO();
                    dao.agregarNacionalidad(n);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
                
            }

            else
           
            {
                MessageBox.Show(" Ingrese una nacionalidad " , " ERROR");
            }
            this.Dispose();
        }

        private void NewNacionalidades_Load(object sender, EventArgs e)
        {

        }

        private void txtNewNacionalidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkHabilitado_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
