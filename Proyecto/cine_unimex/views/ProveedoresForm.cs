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
            consultaBuscarProveedor();
            consultaProveedor();
            cbxbuscarproveedor.DataSource = null;
            cbxbuscarproveedor.Enabled = false;
        }

        public void consultaProveedor()
        {
            ProveedoresDAO dao = new ProveedoresDAO();
            DataTable dtp = dao.LoadProveedor();
            viewProveedor.DataSource = dtp;
            viewProveedor.Columns[0].Visible = false;
        }

        public void consultaBuscarProveedor()
        {
            ProveedoresDAO pre_dao = new ProveedoresDAO();
            try
            {
                DataTable dtbus = pre_dao.LoadNombreProveedor();
                cbxbuscarproveedor.DataSource = dtbus;
                cbxbuscarproveedor.DisplayMember = "proveedor";
                cbxbuscarproveedor.ValueMember = "id_proveedor";
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
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
        public void buscarProveedoresQuery()
        {
            String idpreciobus = "" + cbxbuscarproveedor.SelectedValue;
            ProveedoresDTO precio_dto = new ProveedoresDTO();
            try
            {
                precio_dto.idproveedor = Int32.Parse(idpreciobus);
                ProveedoresDAO pre_dao = new ProveedoresDAO();
                DataTable dtbus1 = pre_dao.cargaBusquedaProveedor(precio_dto);
                viewProveedor.DataSource = dtbus1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fil = viewProveedor.CurrentCell.RowIndex;
            String valor = viewProveedor.Rows[fil].Cells[0].Value.ToString();
            int id = Int32.Parse(valor);
            NewProveedores formaupdate = new NewProveedores(id);
            formaupdate.ShowDialog();
            consultaProveedor();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int fil = viewProveedor.CurrentCell.RowIndex;
            String valor = viewProveedor.Rows[fil].Cells[0].Value.ToString();
            int id2 = Int32.Parse(valor);
            String reg = viewProveedor.Rows[fil].Cells[1].Value.ToString();
            String regprecio = viewProveedor.Rows[fil].Cells[2].Value.ToString();
            DialogResult boton = MessageBox.Show("Desea Eliminar el Proveedor: " + reg + " con la descripcion: " + regprecio, "Borrar Registro", MessageBoxButtons.OKCancel);
            if (boton == DialogResult.OK)
            {
                ProveedoresDTO pdtoup = new ProveedoresDTO();
                pdtoup.idproveedor = id2;

                try
                {
                    ProveedoresDAO daoprecio1 = new ProveedoresDAO();
                    daoprecio1.deleteUsuarioDTO(pdtoup);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
                consultaProveedor();
            }
            else
            {

            }
        }

        private void checkProveedor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkProveedor.Checked)
            {
                cbxbuscarproveedor.Enabled = true;
                consultaBuscarProveedor();
            }
            else
            {
                checkProveedor.Enabled = false;
                cbxbuscarproveedor.DataSource = null;
                consultaProveedor();
            }
        }

        private void cbxbuscarproveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkProveedor.Checked)
            {
                buscarProveedoresQuery();
            }
        }
    }
}