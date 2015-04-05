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
    public partial class ClientesFrecuentesForm : Form
    {
        public ClientesFrecuentesForm()
        {
            InitializeComponent();
        }

        private void ClientesFrecuentesForm_Load(object sender, EventArgs e)
        {
            consultaViewCF();
        }
        public void consultaViewCF ()
        {
            ClientesFrecuentesDAO daoClientesFrecuentes = new ClientesFrecuentesDAO();
            DataTable dtp = daoClientesFrecuentes.cargarClientesFrecuentes();
            dgvClienteFrecuente.DataSource = dtp;
            dgvClienteFrecuente.Columns[0].Visible = false;
        }

        private void btnNuevoCFform_Click(object sender, EventArgs e)
        {
            NewClientesFrecuentes formnewcf = new NewClientesFrecuentes();
            formnewcf.ShowDialog();
            consultaViewCF();
        }

        private void btnActualizarCF_Click(object sender, EventArgs e)
        {
            int fil = dgvClienteFrecuente.CurrentCell.RowIndex;
            String valor = dgvClienteFrecuente.Rows[fil].Cells[0].Value.ToString();
            int id = Int32.Parse(valor);
            NewClientesFrecuentes formaupdate = new NewClientesFrecuentes(id);
            formaupdate.ShowDialog();
            consultaViewCF();
        }
    }
}
