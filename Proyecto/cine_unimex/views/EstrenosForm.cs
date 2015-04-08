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
using System.Data;
using System.Data.SqlClient;
using System.Resources;

namespace unimex.lenguajesv.cine.views
{
    public partial class EstrenosForm : Form
    {
        public EstrenosForm()
        {
            InitializeComponent();
        }


        public void consultaEstrenos()
        {
            EstrenosDAO daoEstrenos = new EstrenosDAO();
            DataTable dte = daoEstrenos.loadEstrenos();
            dtbEstreno.DataSource = dte;
            dtbEstreno.Columns[0].Visible = false;
        }

        public void ConsultaBuscar()
        {
            NacionalidadesDAO nadao3 = new NacionalidadesDAO();
            try
            {
                DataTable dt = nadao3.LoadNacionalidades();
                cmbHabilitado.DataSource = dt;
                cmbHabilitado.DisplayMember = "nombre   ";
                cmbHabilitado.ValueMember = "id_estreno";
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        public void buscarEstreno()
        {
            String idnac = "" + cmbHabilitado.SelectedValue;
            EstrenosDTO dtn_na = new EstrenosDTO();
            try
            {
                dtn_na.Id_estrenos = Int32.Parse(idnac);
                EstrenosDAO nacdao = new EstrenosDAO();
                DataTable dtbuscar = nacdao.BusquedaEstreno(dtn_na);
                dtbEstreno.DataSource = dtbuscar;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NewEstrenos formanac = new NewEstrenos();
            formanac.ShowDialog();
            consultaEstrenos();
        }

        private void EstrenosForm_Load(object sender, EventArgs e)
        {
            consultaEstrenos();
            ConsultaBuscar();
            cmbHabilitado.Enabled = false;
            cmbHabilitado.DataSource = null;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int bf = dtbEstreno.CurrentCell.RowIndex;
            String v = dtbEstreno.Rows[bf].Cells[0].Value.ToString();
            int id3 = Int32.Parse(v);
            String nab = dtbEstreno.Rows[bf].Cells[1].Value.ToString();
            DialogResult gf = MessageBox.Show("Desea Eliminar el estreno: " + nab + "?", "Borrar Registro", MessageBoxButtons.OKCancel);
            if (gf == DialogResult.OK)
            {
                EstrenosDTO nadto = new EstrenosDTO();
                nadto.Id_estrenos = id3;
                try
                {
                    EstrenosDAO nadao2 = new EstrenosDAO();
                    nadao2.borrarEstreno(nadto);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
                consultaEstrenos();
            }
            else
            {

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //Guarda el elemento que seleccione
            int fil = dtbEstreno.CurrentCell.RowIndex;
            String valor = dtbEstreno.Rows[fil].Cells[0].Value.ToString();
            int id = Int32.Parse(valor);
            NewEstrenos formup = new NewEstrenos();
            //id
            formup.ShowDialog();
            consultaEstrenos();

        }

        private void chkHabilitado_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHabilitado.Checked)
            {
                cmbHabilitado.Enabled = true;
                ConsultaBuscar();
            }
            else
            {
                cmbHabilitado.Enabled = false;
                cmbHabilitado.DataSource = null;
                consultaEstrenos();

            }
        }

        private void cmbHabilitado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chkHabilitado.Checked)
            {
                buscarEstreno();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

