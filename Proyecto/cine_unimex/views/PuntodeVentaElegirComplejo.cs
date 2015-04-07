using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using unimex.lenguajesv.cine.DAO;

namespace unimex.lenguajesv.cine.views
{
    public partial class PuntodeVentaElegirComplejo : Form
    {
        public PuntodeVentaElegirComplejo()
        {
            InitializeComponent();
        }
       
        public void buscarComplejoPV()
        {
            PuntodeVentaBoletosDAO pre_dao = new PuntodeVentaBoletosDAO();
            try
            {
                DataTable dtbus = pre_dao.cargarComplejoPV();
                cmbElegirComplejo.DataSource = dtbus;
                cmbElegirComplejo.DisplayMember = "nombre";
                cmbElegirComplejo.ValueMember = "id_complejo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void PuntodeVentaElegirComplejo_Load(object sender, EventArgs e)
        {
            buscarComplejoPV();
        }

        private void btnAcptarPVCompl_Click(object sender, EventArgs e)
        {
            String Complpp = "" + cmbElegirComplejo.SelectedValue;
            int id = Int32.Parse(Complpp);
            String nomcomplejo = "" + cmbElegirComplejo.Text;
            PuntodeVentaForm formapv = new PuntodeVentaForm(id,nomcomplejo);
            formapv.MdiParent = this.MdiParent;
            formapv.Show();
            this.Dispose();


        }
    }
}
