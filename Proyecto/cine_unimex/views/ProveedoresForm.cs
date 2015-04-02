using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using unimex.lenguajesv.cine.DAO;

// Catalogo realizado por Gonzalez Reyes Berenice Izamar

namespace unimex.lenguajesv.cine.views
{
    public partial class ProveedoresForm : Form
    {
        public ProveedoresForm()
        {
            InitializeComponent();
        }

        private void ProveedoresForm_Load(object sender, EventArgs e)
        {
            ConsultarProveedor();
        }
        private void ConsultarProveedor()
        {
            ProveedoresDAO Z_DAO = new ProveedoresDAO();

            try
            {
                DataTable usr = Z_DAO.LoadProveedor();
                viewProveedor.DataSource = usr;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            NewProveedores frmNewProvee = new NewProveedores();
            frmNewProvee.Show();
        }
    }
}