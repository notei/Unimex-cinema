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
    public partial class TipoProyeccionForm : Form
    {
        public TipoProyeccionForm()
        {
            InitializeComponent();
        }

        private void TipoProyeccionForm_Load(object sender, EventArgs e)
        {
            consultaDGVTipoProyecciones();
        }
        public void consultaDGVTipoProyecciones ()
        {
            TipoProyeccionDAO daoTipoProyeccion = new TipoProyeccionDAO();
            DataTable dtn = daoTipoProyeccion.loadTipoProyeccion();
            dtgTipoProyeccion.DataSource = dtn;
            dtgTipoProyeccion.Columns[0].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewTipoproyeccion formaTipoPro = new NewTipoproyeccion();
            formaTipoPro.ShowDialog();
            consultaDGVTipoProyecciones();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int fil = dtgTipoProyeccion.CurrentCell.RowIndex;
            String valor = dtgTipoProyeccion.Rows[fil].Cells[0].Value.ToString();
            int id = Int32.Parse(valor);
            NewTipoproyeccion formaupdateTP = new NewTipoproyeccion(id);
            formaupdateTP.ShowDialog();
            consultaDGVTipoProyecciones();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int fil3 = dtgTipoProyeccion.CurrentCell.RowIndex;
            String valor = dtgTipoProyeccion.Rows[fil3].Cells[0].Value.ToString();
            int id2 = Int32.Parse(valor);
            String reg = dtgTipoProyeccion.Rows[fil3].Cells[1].Value.ToString();
            String regprecio = dtgTipoProyeccion.Rows[fil3].Cells[3].Value.ToString();
            DialogResult boton = MessageBox.Show("Desea Eliminar el Tipo Proyeccion: " + reg +"?", "Borrar Registro", MessageBoxButtons.OKCancel);
            if (boton == DialogResult.OK)
            {

                TipoProyeccionDTO pdtoup = new TipoProyeccionDTO();
                pdtoup.id_TipoProyeccion = id2;

                try
                {
                    TipoProyeccionDAO daoprecio1 = new TipoProyeccionDAO();
                    daoprecio1.deleteTPDTO(pdtoup);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
                consultaDGVTipoProyecciones();
            }
            else
            {

            }
        }
    }
}
