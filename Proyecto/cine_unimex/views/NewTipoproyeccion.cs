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
    public partial class NewTipoproyeccion : Form
    {
        public NewTipoproyeccion()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text != "")
            {
                TipoProyeccionDTO tp = new TipoProyeccionDTO();
                tp.tipoProyeccion = txtTipoproyeccion.Text;
                tp.Descripcion = txtDescripcion.Text;
                tp.Habilitado = checkBox1.Checked;
                try
                {
                    TipoProyeccionDAO dao = new TipoProyeccionDAO();
                    dao.agregarTipoProyeccion(tp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }

            }
            else if (txtTipoproyeccion.Text != "")
            {
                TipoProyeccionDTO tp = new TipoProyeccionDTO();
                tp.tipoProyeccion = txtTipoproyeccion.Text;
                tp.Descripcion = txtDescripcion.Text;
                tp.Habilitado = checkBox2.Checked;
                try
                {
                    TipoProyeccionDAO dao = new TipoProyeccionDAO();
                    dao.agregarTipoProyeccion(tp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }


            }

            else
            {
                MessageBox.Show("Ingresa tipo proyeccion o Descripción", "Alerta");
            }
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void NewTipoProyeccion_Load(object sender, EventArgs e)
        {

        }
    }
}
