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
            dtgTipoProyeccion.DefaultCellStyle.BackColor = Color.LightGray;
            dtgTipoProyeccion.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;
            consultaDGVTipoProyecciones();
            consultaBuscarTipoProyeccion();
            cbxBuscarTP.Enabled = false;
            cbxBuscarTP.DataSource = null;
        }
        public void consultaDGVTipoProyecciones ()
        {
            TipoProyeccionDAO daoTipoProyeccion = new TipoProyeccionDAO();
            DataTable dtn = daoTipoProyeccion.loadTipoProyeccion();
            dtgTipoProyeccion.DataSource = dtn;
            dtgTipoProyeccion.Columns[0].Visible = false;
        }
        public void consultaBuscarTipoProyeccion ()
        {
            TipoProyeccionDAO pTP_dao = new TipoProyeccionDAO();
            try
            {
                DataTable dtbus = pTP_dao.LoadTipoProyeccion();
                cbxBuscarTP.DataSource = dtbus;
                cbxBuscarTP.DisplayMember = "tipo_proyeccion";
                cbxBuscarTP.ValueMember = "id_tipo_proyeccion";
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        public void buscarTipoProyeccion ()
        {
            String idtpbus = "" + cbxBuscarTP.SelectedValue;
            TipoProyeccionDTO ttp_dto = new TipoProyeccionDTO();
            try
            {
                ttp_dto.id_TipoProyeccion = Int32.Parse(idtpbus);
                TipoProyeccionDAO ttp_dao = new TipoProyeccionDAO();
                DataTable dtbus1 = ttp_dao.cargaBusquedaTP(ttp_dto);
                dtgTipoProyeccion.DataSource = dtbus1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }


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
            int fil = dtgTipoProyeccion.CurrentCell.RowIndex;
            String valor = dtgTipoProyeccion.Rows[fil].Cells[0].Value.ToString();
            int id2 = Int32.Parse(valor);
            String reg = dtgTipoProyeccion.Rows[fil].Cells[1].Value.ToString();            
            DialogResult boton = MessageBox.Show("Desea Eliminar el Tipo Proyeccion: " + reg + " ?", "Borrar Registro", MessageBoxButtons.OKCancel);
            if (boton == DialogResult.OK)
            {

               TipoProyeccionDTO pdtoup = new TipoProyeccionDTO();
                pdtoup.id_TipoProyeccion = id2;

                try
                {
                    TipoProyeccionDAO daotproyeccion = new TipoProyeccionDAO();
                    daotproyeccion.deleteTPDTO(pdtoup);
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

        private void chkBuscarTP_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBuscarTP.Checked)
            {
                cbxBuscarTP.Enabled = true;
                consultaBuscarTipoProyeccion();
            }
            else 
            {
                cbxBuscarTP.Enabled = false;
                cbxBuscarTP.DataSource = null;
                consultaDGVTipoProyecciones();
            }
        }

        private void cbxBuscarTP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chkBuscarTP.Checked)
            {
                buscarTipoProyeccion();
            }
        }
    }
}
