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
    public partial class NewComplejo : Form
    {
        private int id;
        Boolean istt = false;
        public NewComplejo()
        {
            InitializeComponent();
            istt = true;
            btnAgregarCom.Text = "Agregar";
        }
        public NewComplejo(int id)
        {
            InitializeComponent();
            this.id = id;
            istt = false;
            btnAgregarCom.Text = "Actualizar";
        }
        private void btnAgregarCom_Click(object sender, EventArgs e)
        {
            if (istt)
            {
                ComplejoDTO pdto = new ComplejoDTO();
                pdto.Nombre = txtNombreCompl.Text;
                pdto.Direccion = txtDireccion.Text;
                pdto.Telefono = txtTelefono.Text;
                pdto.Habilitado = chkHabilitadoCompl.Checked;
                try
                {
                    ComplejoDAO daoprecio = new ComplejoDAO();
                    daoprecio.agregarComplejo(pdto);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
                this.Dispose();
            }
            else
            {
                ComplejoDTO pdtoup = new ComplejoDTO();
                pdtoup.id_Complejos = id;
                pdtoup.Nombre = txtNombreCompl.Text;
                pdtoup.Direccion = txtDireccion.Text;
                pdtoup.Telefono = txtTelefono.Text;
                pdtoup.Habilitado = chkHabilitadoCompl.Checked;
                try
                {
                    ComplejoDAO daoprecio1 = new ComplejoDAO();
                    daoprecio1.updateComplejoDTO(pdtoup);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
                this.Dispose();
            }
        }

        private void NewComplejo_Load(object sender, EventArgs e)
        {

        }
    }
}
