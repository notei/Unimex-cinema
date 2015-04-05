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
    public partial class PreciosForm : Form
    {
        public PreciosForm()
        {
            InitializeComponent();
        }

        private void PreciosForm_Load(object sender, EventArgs e)
        {
            consultaPrecios();
        }

        public void consultaPrecios()
        {
            PreciosDAO daoPrecios = new PreciosDAO();
            DataTable dtp = daoPrecios.loadPrecios();
            dgvPrecios.DataSource=dtp;
            dgvPrecios.Columns[0].Visible = false;
        }

        private void btnAgregarprecio_Click(object sender, EventArgs e)
        {
            NewPrecios formpre = new NewPrecios();
            formpre.ShowDialog();
            consultaPrecios();
        }

        private void btnActualizarPrecios_Click(object sender, EventArgs e)
        {
            int fil = dgvPrecios.CurrentCell.RowIndex;
            String valor = dgvPrecios.Rows[fil].Cells[0].Value.ToString();
            int id = Int32.Parse(valor);
            NewPrecios formaupdate = new NewPrecios(id);
            formaupdate.ShowDialog();
            consultaPrecios();
        }

        private void btnBorrarPrecio_Click(object sender, EventArgs e)
        {
            int fil = dgvPrecios.CurrentCell.RowIndex;
            String valor = dgvPrecios.Rows[fil].Cells[0].Value.ToString();
            int id2 = Int32.Parse(valor);
            DialogResult boton = MessageBox.Show("Desea Eliminar el registro seleccionado", "Borrar Registro", MessageBoxButtons.OKCancel);
            if (boton == DialogResult.OK)
            {
                
                PreciosDTO pdtoup = new PreciosDTO();
                pdtoup.id_Precios = id2;

                try
                {
                    PreciosDAO daoprecio1 = new PreciosDAO();
                    daoprecio1.deletePrecioDTO(pdtoup);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
                MessageBox.Show("Borrado con Exito!");
                consultaPrecios();
            }
            else
            {
                
            }
        }
            
    }
}
