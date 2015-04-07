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
    public partial class NewProveedores : Form
    {
        private int id;
        Boolean isInsertId = false;
        public NewProveedores()
        {
            InitializeComponent();
            isInsertId = true;
            btnaceptar.Text = "Agregar";
        }

        public NewProveedores(int id)
        {
            InitializeComponent();
            this.id = id;
            isInsertId = false;
            btnaceptar.Text = "Actualizar";
        }

        public void cargarNewProveedorsUpdate()
        {
            try
            {
                ProveedoresDAO presdao = new ProveedoresDAO();
                ProveedoresDTO presdto = presdao.cargarProveedoresUpdate(id);
                txtnamepro.Text = presdto.proveedores;
                txtdetallespro.Text = presdto.detalle;
                checkpro.Checked = presdto.Habilitado;

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }

        private void NewProveedores_Load(object sender, EventArgs e)
        {
            if (isInsertId)
            {
                ProveedoresDAO predaao = new ProveedoresDAO();
                predaao.LoadProveedor();
            }
            else
            {
                cargarNewProveedorsUpdate();
            }
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (isInsertId)
            {
                if (txtnamepro.Text != "")
                {
                    ProveedoresDTO n = new ProveedoresDTO();
                    n.proveedores = txtnamepro.Text;
                    n.detalle = txtdetallespro.Text;
                    n.Habilitado = checkpro.Checked;


                    try
                    {
                        ProveedoresDAO dao = new ProveedoresDAO();
                        dao.agregarProveedor(n);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }

                }

                else
                {
                    MessageBox.Show(" Ingrese un Proveedor ", " ERROR");
                }
                this.Dispose();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}


