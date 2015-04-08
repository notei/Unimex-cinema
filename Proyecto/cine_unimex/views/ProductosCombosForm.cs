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
    public partial class ProductosCombosForm : Form
    {
        public ProductosCombosForm()
        {
            InitializeComponent();
        }

        private void ProductosCombosForm_Load(object sender, EventArgs e)
        {
            productosCombos();
            dataGridView1PC.DefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1PC.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;
        }
        public void productosCombos()
        {
            //Creacion de un objeto de la clase ProductosCombosDAO el cual la representara con una variable 
            ProductosCombosDAO PC_DAO = new ProductosCombosDAO();

            //contiene el código protegido que puede causar la excepción, hasta que se hasta completarse satisfactoriamente
            try
            {
                DataTable pc = PC_DAO.LoadProductosCombos();
                dataGridView1PC.DataSource = pc;
            }
            //Se controla la excepcion,  y muestra una ventana con la causa de la excepcion  
            catch (Exception exe)
            {
                MessageBox.Show("" + exe);
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //Cierre el formulario actual
            this.Dispose();
            //Llama al formulario NewProductosCombos
            NewProductosCombos frmNewProy = new NewProductosCombos();
            frmNewProy.ShowDialog();
            frmNewProy.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Creacion de un objeto de la clase ProductosCombosDTO el cual la representara con una variable
            ProductosCombosDTO prodc = new ProductosCombosDTO();
            //Se asigna valor a Id_Combo con a traves de lo ingresado en el txtEliminar
            prodc.Id_Combo = Int32.Parse(txtEliminar.Text);
            try
            {
                ProductosCombosDAO pcom_dao = new ProductosCombosDAO();
                pcom_dao.deleteProductosCombos(prodc);
                //Mensaje de sastisfacion al ejecutarse por completo la intruccion
                MessageBox.Show("Se ha Eliminado exitosamente el registro");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            //Cierre el formulario actual
            this.Dispose();
            //Llama al formulario ProductosCombosForm
            ProductosCombosForm pcf = new ProductosCombosForm();
            pcf.ShowDialog();
            pcf.StartPosition = FormStartPosition.CenterScreen;
        }

        private void dataGridView1PC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
