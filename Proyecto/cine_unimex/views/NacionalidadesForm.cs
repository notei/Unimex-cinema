using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using unimex.lenguajesv.cine.DTO;

namespace unimex.lenguajesv.cine.views
{
    public partial class NacionalidadesForm : Form
    {
        public NacionalidadesForm()
        {
            InitializeComponent();
        }

        private void NacionalidadesForm_Load(object sender, EventArgs e)
        {
            consutaNacinalidades();

        }
        public void consutaNacinalidades()
        {
            NacionalidadesDAO daoNacionalidad = new NacionalidadesDAO();
            DataTable dtn = daoNacionalidad.loadNacionalidades();
            dgvNacionalidades.DataSource = dtn;
            dgvNacionalidades.Columns[0].Visible = false;
        }

        private void btnAgregarNac_Click(object sender, EventArgs e)
        {
            NewNacionalidades formanac = new NewNacionalidades();
            formanac.ShowDialog();
            consutaNacinalidades();
            /* Por favor agrega un evento para que al cerrar el formulario automaticamente
             * actualize el dataGridView sin necesidad de volverlo a abrir. atte Alex. */


        }

        private void dgvNacionalidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnActualizarNa_Click(object sender, EventArgs e)
        {
            //Guarda el elemento que seleccione
            int fil = dgvNacionalidades.CurrentCell.RowIndex;

            String valor = dgvNacionalidades.Rows[fil].Cells[0].Value.ToString();
            int id = Int32.Parse(valor);
            NewNacionalidades formup = new NewNacionalidades (id);
            formup.ShowDialog();
            consutaNacinalidades();

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int bf = dgvNacionalidades.CurrentCell.RowIndex;
            String v = dgvNacionalidades.Rows[bf].Cells[0].Value.ToString();
            int id3 = Int32.Parse(v);
            String nab = dgvNacionalidades.Rows[bf].Cells[1].Value.ToString();
            DialogResult gf = MessageBox.Show("Desea Eliminar la Nacionalidad: "+nab+"?", "Borrar Registro", MessageBoxButtons.OKCancel);
            if (gf == DialogResult.OK)
            {
                NacionalidadesDTO nadto = new NacionalidadesDTO();
                nadto.id_Nacionalidad = id3;
                try
                {
                    NacionalidadesDAO nadao2 = new NacionalidadesDAO();
                    nadao2.borrarNacionalidad(nadto);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
                consutaNacinalidades();
            }
            else 
            { 
            
            }
        }


    }
}
