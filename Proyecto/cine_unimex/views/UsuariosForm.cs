
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
    public partial class UsuariosForm : Form
    {
        public UsuariosForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UsuariosForm_Load(object sender, EventArgs e)
        {
            ConsultarUsuario();
        }
        public void ConsultarUsuario()
        {
            UsuariosDAO U_DAO = new UsuariosDAO();
            try
            {
                DataTable usr = U_DAO.LoadUsuarios();
                dataGridView1.DataSource = usr;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        
        private void modbtn_Click_1(object sender, EventArgs e)
        {
            NewUsuarios frmNewUsua = new NewUsuarios();
            frmNewUsua.Show();
        }
    }
}