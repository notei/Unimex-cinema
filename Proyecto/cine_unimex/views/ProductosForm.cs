
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
    public partial class ProductosForm : Form
    {
        public ProductosForm()
        {
            InitializeComponent();
        }

        private void ProductosForm_Load(object sender, EventArgs e)
        {
            ConsultarProducto();
        }

        public void ConsultarProducto()
        {
            ProductosDAO U_DAO = new ProductosDAO();
            try
            {
                DataTable usr = U_DAO.LoadProductos();
                dataGridView1.DataSource = usr;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            NewProductos frmNewPro = new NewProductos();
            frmNewPro.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fil = dataGridView1.CurrentCell.RowIndex;
            String valor = dataGridView1.Rows[fil].Cells[0].Value.ToString();
            int id2 = Int32.Parse(valor);
            String reg = dataGridView1.Rows[fil].Cells[1].Value.ToString();
            String regproducto = dataGridView1.Rows[fil].Cells[3].Value.ToString();
            DialogResult boton = MessageBox.Show("Desea eliminar el producto que agrego: " + reg + " con el nombre de.." + regproducto, "Borrar Registro", MessageBoxButtons.OKCancel);
            if (boton == DialogResult.OK)
            {

                 ProductosDAO nadto = new ProductosDTO();
                    nadto.id_Productos= id2;
                    try
                    {
                        ProductosDAO nadao2 = new ProductosDAO();
                        nadao2.borrarProductos(nadto);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                    ConsultarProducto();
                }
            else
            {

            }
        }

        private void chkProducto_CheckedChanged(object sender, EventArgs e)
        {
            if (chkProducto.Checked)
            {
                cmbProducto.Enabled = true;
                ConsultarProducto();
            }
            else
            {
                cmbProducto.Enabled = false;
                cmbProducto.DataSource = null;
                ConsultarProducto();
            }
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chkProducto.Checked)
            {
                buscarProductos();
            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            int fil = dataGridView1.CurrentCell.RowIndex;
            String valor = dataGridView1.Rows[fil].Cells[0].Value.ToString();
            int id = Int32.Parse(valor);

            NewProductos formapro = new NewProductos(id);
            formapro.ShowDialog();
            ConsultarProducto();
            
        }
        }
    }


