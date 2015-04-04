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
    public partial class SalasForm : Form
    {
        public SalasForm()
        {
            InitializeComponent();
        }

        private void ComplejosForm_Load(object sender, EventArgs e)
        {
            consultaComplejos();

        }
        private void consultaComplejos()
        {
            SalasDAO Com_DAO = new SalasDAO();
            try
            {
                DataTable dt = Com_DAO.loadSalas();
                dataG.DataSource = dt;

            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewSalas frmNewSalas = new NewSalas();
            frmNewSalas.Show();
            frmNewSalas.Dispose();
        }
    }
}
