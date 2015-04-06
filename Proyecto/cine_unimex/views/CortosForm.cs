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
    public partial class CortosForm : Form
    {
        public CortosForm()
        {
            InitializeComponent();
        }

        private void CortosForm_Load(object sender, EventArgs e)
        {
            
            consultaCorto();
        }

        public void consultaCorto()
        {
            CortosDAO C_DAO = new CortosDAO();

            try
            {
                DataTable dt = C_DAO.loadCortos();
                dgvcortos.DataSource = dt;

            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void Agregarbtn_Click(object sender, EventArgs e)
        {
            NewCortos frmNewCorto = new NewCortos();
            frmNewCorto.Show();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            int fila = dgvcortos.CurrentCell.RowIndex;
            String valor = dgvcortos.Rows[fila].Cells[0].Value.ToString();
            int id = Int32.Parse(valor);
            NewCortos frmNewCorto = new NewCortos(id);
            frmNewCorto.Show();


        }
    }
}
