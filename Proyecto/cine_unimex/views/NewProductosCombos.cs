using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using unimex.lenguajesv.cine.DTO;
using unimex.lenguajesv.cine.DAO;

namespace unimex.lenguajesv.cine.views
{
    public partial class NewProductosCombos : Form
    {
        public NewProductosCombos()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Cierre el formulario actual
            this.Dispose();
            //Llama al formulario ProductosCombosForm
            ProductosCombosForm pcf = new ProductosCombosForm();
            pcf.ShowDialog();
            pcf.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Llamado del metodo newProductosCombos
            newProductosCombos();
            //Cierre el formulario actual
            this.Dispose();
        }
        public void newProductosCombos()
        {
            //Creacion de un objeto de la clase ProductosCombosDTO el cual la representara con una variable
            ProductosCombosDTO pc_dto = new ProductosCombosDTO();
            //Ingreso de valores
            pc_dto.Nombre = txtNombre.Text;
            pc_dto.Descripcion = txtDescripcion.Text;
            pc_dto.Precio = Int32.Parse(txtPrecio.Text);
            pc_dto.Habilitado = HabilitadocheckBox.Checked;
            try
            {
                ProductosCombosDAO pcom_dao = new ProductosCombosDAO();
                pcom_dao.newProductosCombos(pc_dto);
                //Mensaje de sastisfacion al ejecutarse por completo la intruccion
                MessageBox.Show("Se ha guardado con exito el nuevo registro");
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Creacion de un objeto de la clase ProductosCombosDTO el cual la representara con una variable
            ProductosCombosDTO prodc = new ProductosCombosDTO();
            //Ingreso de valores
            prodc.Id_Combo = Int32.Parse(txtIdCombo.Text);
            prodc.Nombre = txtNombre.Text;
            prodc.Descripcion = txtDescripcion.Text;
            prodc.Precio = Int32.Parse(txtPrecio.Text);
            prodc.Habilitado = HabilitadocheckBox.Checked;
            try
            {
                ProductosCombosDAO pcom_dao = new ProductosCombosDAO();
                pcom_dao.editProductosCombos(prodc);
                //Mensaje de sastisfacion al ejecutarse por completo la intruccion
                MessageBox.Show("Se han guardado con exito los cambios realizados en el registro");
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
    }
}
