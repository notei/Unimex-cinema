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
           
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void NewTipoProyeccion_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            TipoProyeccionDTO tpdto = new TipoProyeccionDTO();
            tpdto.tipoProyeccion = txtTipoproyeccion.Text;
            tpdto.Descripcion = txtDescripcion.Text;
            tpdto.Habilitado = checkHabilitado.Checked;
            try
            {
                TipoProyeccionDAO daoTP = new TipoProyeccionDAO();
                daoTP.agregarTipoproyeccion(tpdto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            this.Dispose();

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
