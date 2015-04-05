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
    public partial class NewClientesFrecuentes : Form
    {
        public NewClientesFrecuentes()
        {
            InitializeComponent();
        }

        private void btnCFNuevo_Click(object sender, EventArgs e)
        {
            ClientesFrecuentesDTO cfdto = new ClientesFrecuentesDTO();
            cfdto.Nombre = txtNombreNew.Text;
            cfdto.Apellido_Paterno = txtApellidoNew.Text;
            cfdto.User_Name = txtUserNew.Text;
            cfdto.Habilitado = chkHabilitadoNew.Checked;
            try
            {
                ClientesFrecuentesDAO daoclientefrecuente = new ClientesFrecuentesDAO();
                daoclientefrecuente.agregarClienteFrecuente(cfdto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            this.Dispose();
        }

        private void btnCancelarNew_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
