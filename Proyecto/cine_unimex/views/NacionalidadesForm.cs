using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace unimex.lenguajesv.cine.views
{
    public partial class NacionalidadesForm : Form
    {
        public NacionalidadesForm()
        {
            InitializeComponent();
        }

        private void NacionalidadesForm_Load(object sender, EventArgs e)
        {
            consutaNacinalidades();
        }
        public void consutaNacinalidades()
        {
            NacionalidadesDAO daoNacionalidad = new NacionalidadesDAO();
            DataTable dtn = daoNacionalidad.loadNacionalidades();
            dgvNacionalidades.DataSource = dtn;
            dgvNacionalidades.Columns[0].Visible = false;
        }

        private void btnAgregarNac_Click(object sender, EventArgs e)
        {
            NewNacionalidades formanac = new NewNacionalidades();
            formanac.ShowDialog();


        }


    }
}
