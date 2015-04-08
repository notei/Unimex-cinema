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
    public partial class NewProductos : Form
    {
        private int id;
        Boolean siestaAct = false;
        public NewProductos()
        {
            InitializeComponent();
            siestaAct = true;
            btnaceptar.Text = "Agregar";
        }
        public NewProductos(int id)
        {

            InitializeComponent();
            this.id = id;
            siestaAct = false;
            btnaceptar.Text = "Actualizar";

        }

        private void NewProductos_Load(object sender, EventArgs e)
        {
            if (siestaAct)
            {
                ProductosDAO predaao = new ProductosDAO();
                predaao.LoadProductos();
            }
            else
            {
                cargarNewProductosUpdate();
            }
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (siestaAct)
            {

                if (txtnombre.Text != "")
                {
                    ProductosDTO n = new ProductosDTO();
                    n.Nombre = txtnombre.Text;
                    n.Descripcion = txtdescripcion.Text;
                    n.Habilitar = btncheck.Checked;


                    try
                    {
                        ProductosDAO dao = new ProductosDAO();
                        dao.agregarProducto(n);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }

                }


                else
                {
                    MessageBox.Show(" Ingrese un Producto ", " ERROR");
                }
                this.Dispose();
            }
            else
            {
                ProductosDTO pdtoup = new ProductosDTO();
                pdtoup.IdTipoProducto = id;
                pdtoup.Nombre = txtnombre.Text;
                pdtoup.Descripcion = txtdescripcion.Text;
                pdtoup.Habilitar = btncheck.Checked;
                try
                {
                    ProductosDAO daoprecio1 = new ProductosDAO();
                    daoprecio1.updatePoductoDTO(pdtoup);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
                this.Dispose();

            }


        }
        public void cargarNewProductosUpdate()
        {
            try
            {
                ProductosDAO presdao = new ProductosDAO();
                ProductosDTO presdto = presdao.cargarProductosUpdate(id);
                txtnombre.Text = presdto.Nombre;
                txtdescripcion.Text = presdto.Descripcion;
                btncheck.Checked = presdto.Habilitar;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btncheck_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}




















