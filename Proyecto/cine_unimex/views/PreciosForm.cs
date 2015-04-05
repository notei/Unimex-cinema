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
    public partial class PreciosForm : Form
    {
        public PreciosForm()
        {
            InitializeComponent();
        }

        private void PreciosForm_Load(object sender, EventArgs e)
        {
            consultaPrecios();
        }

        public void consultaPrecios()
        {
            PreciosDAO daoPrecios = new PreciosDAO();
            DataTable dtp = daoPrecios.loadPrecios();
            dgvPrecios.DataSource=dtp;
            dgvPrecios.Columns[0].Visible = false;
        }

        private void btnAgregarprecio_Click(object sender, EventArgs e)
        {
            NewPrecios formpre = new NewPrecios();
            formpre.ShowDialog();
            consultaPrecios();
        }

        private void btnActualizarPrecios_Click(object sender, EventArgs e)
        {
            int fil = dgvPrecios.CurrentCell.RowIndex;
            String valor = dgvPrecios.Rows[fil].Cells[0].Value.ToString();
            int id = Int32.Parse(valor);
            NewPrecios formaupdate = new NewPrecios(id);
            formaupdate.Show();
        }
            
    }
}
