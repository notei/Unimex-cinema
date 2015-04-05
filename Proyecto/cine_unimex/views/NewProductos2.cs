using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using unimex.lenguajesv.cine.DTO;//Importamos DTO Para acceder a ella
using unimex.lenguajesv.cine.DAO; //Importamos DAO

namespace unimex.lenguajesv.cine.views
{
    public partial class NewProductos2 : Form
    {
        public NewProductos2()
        {
            InitializeComponent();
        }

        private void NewProductos2_Load(object sender, EventArgs e)
        {

        }

        public void newproductos2 ()
        {
            ProductosDTO2 proy_dto = new ProductosDTO2();
            proy_dto.Nombre = textNombre.Text;
            proy_dto.Descripcion = textDescripcion.Text;
            proy_dto.Precio = Int32.Parse(textPrecio.Text);
            proy_dto.Disponibilidad = Int32.Parse(textDisponibilidad.Text);
            proy_dto.Id_tipo_producto = Int32.Parse(textIdTipoProducto.Text);
            proy_dto.Id_proveedor = Int32.Parse(textIdProveedor.Text);
            try
            {
                ProductosDAO2 proy_dao = new ProductosDAO2 ();
                proy_dao.newproductos2(proy_dto);





            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
                


            {

            }

              
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            newproductos2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
