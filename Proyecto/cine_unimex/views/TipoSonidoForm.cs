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
    public partial class TipoSonidoForm : Form
    {
        public TipoSonidoForm()
        {
            InitializeComponent();
        }

        private void TipoSonidoForm_Load(object sender, EventArgs e)
        {
            consultaDGVTipoSonido();
        }
        public void consultaDGVTipoSonido()
        {
            TipoSonidoDAO daoTipoSonido = new TipoSonidoDAO();
            DataTable dtn = daoTipoSonido.loadTipoSonido();
            dgvTipoSonido.DataSource = dtn;
            dgvTipoSonido.Columns[0].Visible = false;
        }

        private void btnNuevoTipoSonido_Click(object sender, EventArgs e)
        {
            NewTipoSonido formasonido = new NewTipoSonido();
            formasonido.ShowDialog();
            consultaDGVTipoSonido();
        }

        private void btnActualizarNew_Click(object sender, EventArgs e)
        {
            int fil = dgvTipoSonido.CurrentCell.RowIndex;
            String valor = dgvTipoSonido.Rows[fil].Cells[0].Value.ToString();
            int id = Int32.Parse(valor);
            NewTipoSonido formaupdatesonido = new NewTipoSonido(id);
            formaupdatesonido.ShowDialog();
            consultaDGVTipoSonido();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int fil = dgvTipoSonido.CurrentCell.RowIndex;
            String valor = dgvTipoSonido.Rows[fil].Cells[0].Value.ToString();
            int id2 = Int32.Parse(valor);
            String reg = dgvTipoSonido.Rows[fil].Cells[1].Value.ToString();
            DialogResult boton = MessageBox.Show("Desea Eliminar el Tipo Sonido: " + reg + " ?", "Borrar Registro", MessageBoxButtons.OKCancel);
            if (boton == DialogResult.OK)
            {

               TipoSonidoDTO pdtoup = new TipoSonidoDTO();
                pdtoup.id_TipoSonido = id2;

                try
                {
                    TipoSonidoDAO daoprecio1 = new TipoSonidoDAO();
                    daoprecio1.deleteTsonidoDTO(pdtoup);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
                consultaDGVTipoSonido();
            }
            else
            {

            }
        }
    }
}
