
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

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            int fil = dataGridView1.CurrentCell.RowIndex;
            String valor = dataGridView1.Rows[fil].Cells[0].Value.ToString();
            int id = Int32.Parse(valor);

            NewProductos formapro = new NewProductos(id);
            formapro.ShowDialog();
            ConsultarProducto();

        }


        private void btnborrar_Click(object sender, EventArgs e)
        {
            {
                int fil = dataGridView1.CurrentCell.RowIndex;
                String valor = dataGridView1.Rows[fil].Cells[0].Value.ToString();
                int id2 = Int32.Parse(valor);
                String reg = dataGridView1.Rows[fil].Cells[1].Value.ToString();
                DialogResult boton = MessageBox.Show("Desea Eliminar el Tipo Producto: " + reg + " ?", "Borrar Registro", MessageBoxButtons.OKCancel);
                if (boton == DialogResult.OK)
                {

                    ProductosDTO protoup = new ProductosDTO();
                    protoup.IdTipoProducto = id2;

                    try
                    {
                      ProductosDAO daoproducto1 = new ProductosDAO();
                        daoproducto1.deleteTPDTO(protoup);
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

                {


                   
        }


    }
        }
}
