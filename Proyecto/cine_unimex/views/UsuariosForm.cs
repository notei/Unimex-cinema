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
            ConsultaBuscarUsuario();
            consultaUsuarios();
            cbxbuscarnombre.DataSource = null;
            cbxbuscarnombre.Enabled = false;
        }

        public void consultaUsuarios()
        {
            UsuariosDAO dao = new UsuariosDAO();
            DataTable dtp = dao.LoadUsuarios();
            dataGridView1.DataSource = dtp;
            dataGridView1.Columns[0].Visible = false;
        }

        public void consultaBuscarPUsu()
        {
            UsuariosDAO pre_dao = new UsuariosDAO();
            try
            {
                DataTable dtbus = pre_dao.LoadNombreUsuario();
                cbxbuscarnombre.DataSource = dtbus;
                cbxbuscarnombre.DisplayMember = "nombre";
                cbxbuscarnombre.ValueMember = "idUsuario";
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        public void ConsultaBuscarUsuario()
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

        private void button1_Click(object sender, EventArgs e)
        {
            int fil = dataGridView1.CurrentCell.RowIndex;
            String valor = dataGridView1.Rows[fil].Cells[0].Value.ToString();
            int id = Int32.Parse(valor);
            NewUsuarios formaupdate = new NewUsuarios(id);
            formaupdate.ShowDialog();
            consultaUsuarios();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int fil = dataGridView1.CurrentCell.RowIndex;
            String valor = dataGridView1.Rows[fil].Cells[0].Value.ToString();
            int id2 = Int32.Parse(valor);
            String reg = dataGridView1.Rows[fil].Cells[1].Value.ToString();
            String regprecio = dataGridView1.Rows[fil].Cells[2].Value.ToString();
            DialogResult boton = MessageBox.Show("Desea Eliminar el Usuario: " + reg + " con el Apellido: $" + regprecio, "Borrar Registro", MessageBoxButtons.OKCancel);
            if (boton == DialogResult.OK)
            {
                UsuariosDTO pdtoup = new UsuariosDTO();
                pdtoup.idusuario = id2;

                try
                {
                    UsuariosDAO daoprecio1 = new UsuariosDAO();
                    daoprecio1.deleteUsuarioDTO(pdtoup);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
                consultaUsuarios();
            }
            else
            {

            }
        }

        private void checkNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNombre.Checked)
            {
                cbxbuscarnombre.Enabled = true;
                ConsultaBuscarUsuario();
            }
            else
            {
                cbxbuscarnombre.Enabled = false;
                cbxbuscarnombre.DataSource = null;
                consultaUsuarios();
            }
        }

        private void cbxbuscarnombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkNombre.Checked)
            {
                ConsultaBuscarUsuario();
            }
        }
    }
}