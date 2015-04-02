
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
    }
}
