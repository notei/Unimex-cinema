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
    public partial class ProductosForm2 : Form
    {
        public ProductosForm2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public void consultaProductos()
        {
            ProductosDAO P_DAO = new ProductosDAO();
            try
            {
                DataTable dt = P_DAO.LoadProductos();
                ProductosDgv.DataSource = dt;


            }
            catch(Exception ex)

            {
                MessageBox.Show("" + ex);
            }
        }

        private void ProductosForm2_Load(object sender, EventArgs e)
        {
           consultaProductos();
        }
    }
}
