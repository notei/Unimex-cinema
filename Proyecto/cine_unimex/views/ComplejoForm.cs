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
    public partial class ComplejoForm : Form
    {
        public ComplejoForm()
        {
            InitializeComponent();
        }

        private void ComplejoForm_Load(object sender, EventArgs e)
        {
            consultaComplejos();
            consultaBuscarComplejo();
            cmbBuscarCom.Enabled = false;
            cmbBuscarCom.DataSource = null;
        }
        public void consultaComplejos()
        {
           ComplejoDAO daoPcom = new ComplejoDAO();
            DataTable dtp = daoPcom.loadComplejos();
            dgvComplejos.DataSource = dtp;
            dgvComplejos.Columns[0].Visible = false;
        }
        public void consultaBuscarComplejo()
        {
            ComplejoDAO pre_dao = new ComplejoDAO();
            try
            {
                DataTable dtbus = pre_dao.LoadNombrePrecio();
                cmbBuscarCom.DataSource = dtbus;
                cmbBuscarCom.DisplayMember = "nombre";
                cmbBuscarCom.ValueMember = "id_complejo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        public void buscarComplejo()
        {
            String idpreciobus = "" + cmbBuscarCom.SelectedValue;
            ComplejoDTO precio_dto = new ComplejoDTO();
            try
            {
                precio_dto.id_Complejos = Int32.Parse(idpreciobus);
                ComplejoDAO com_dao = new ComplejoDAO();
                DataTable dtbus1 = com_dao.cargaBusquedaComplejo(precio_dto);
                dgvComplejos.DataSource = dtbus1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }


        }
        private void btnAgregarCompl_Click(object sender, EventArgs e)
        {
            NewComplejo formpre = new NewComplejo();
            formpre.ShowDialog();
            consultaComplejos();
        }

        private void btnActualizarCom_Click(object sender, EventArgs e)
        {
            int fil = dgvComplejos.CurrentCell.RowIndex;
            String valor = dgvComplejos.Rows[fil].Cells[0].Value.ToString();
            int id = Int32.Parse(valor);
            NewComplejo formaupdate = new NewComplejo(id);
            formaupdate.ShowDialog();
            consultaComplejos();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int fil = dgvComplejos.CurrentCell.RowIndex;
            String valor = dgvComplejos.Rows[fil].Cells[0].Value.ToString();
            int id2 = Int32.Parse(valor);
            String reg = dgvComplejos.Rows[fil].Cells[1].Value.ToString();
            String regprecio = dgvComplejos.Rows[fil].Cells[3].Value.ToString();
            DialogResult boton = MessageBox.Show("Desea Eliminar el Complejo: " + reg , "Borrar Registro", MessageBoxButtons.OKCancel);
            if (boton == DialogResult.OK)
            {

                ComplejoDTO pdtoup = new ComplejoDTO();
                pdtoup.id_Complejos = id2;

                try
                {
                    ComplejoDAO daoprecio1 = new ComplejoDAO();
                    daoprecio1.deleteComplejoDTO(pdtoup);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
                consultaComplejos();
            }
            else
            {

            }
        }

        private void chkBuscarCom_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBuscarCom.Checked)
            {
                cmbBuscarCom.Enabled = true;
                consultaBuscarComplejo();
            }
            else
            {
                cmbBuscarCom.Enabled = false;
                cmbBuscarCom.DataSource = null;
               consultaComplejos();
            }
        }

        private void cmbBuscarCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chkBuscarCom.Checked)
            {
                buscarComplejo();
            }

        }
    }
}
