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
    public partial class SalasForm : Form
    {
        public SalasForm()
        {
            InitializeComponent();
        }

        private void ComplejosForm_Load(object sender, EventArgs e)
        {
            consultaComplejos();
            consutaSala();
            combox1.DataSource = null;
            combox1.Enabled = false;
        }
        private void consultaComplejos()
        {
            SalasDAO Com_DAO = new SalasDAO();
            try
            {
                DataTable dt = Com_DAO.loadSalas();
                dataG.DataSource = dt;
               
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
 
            }
        }
        public void disposeNew(object Source, EventArgs args)
        {
            consultaComplejos();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            NewSalas frmNewSalas = new NewSalas();
            frmNewSalas.MdiParent = this.MdiParent;
            frmNewSalas.Show();
            frmNewSalas.Disposed += new EventHandler(disposeNew);
            
            
        }
        public void consutaSala()
        {
            SalasDAO S_sala = new SalasDAO();

            try
            {

                DataTable db = S_sala.loadProyeccion();
                combox1.DataSource = db;
                combox1.DisplayMember = "tipo_proyeccion";
                combox1.ValueMember = "id_tipo_proyeccion";
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        

        private void btnact_Click(object sender, EventArgs e)
        {
            int renglon = dataG.CurrentCell.RowIndex;
            String valor = dataG.Rows[renglon].Cells[0].Value.ToString();
            int id = Int32.Parse(valor);
            NewSalas frmNewSalas = new NewSalas(id);
            frmNewSalas.MdiParent = this.MdiParent;
            frmNewSalas.Show();
            frmNewSalas.Disposed += new EventHandler(disposeNew);
            
        }

        private void Checksala_CheckedChanged(object sender, EventArgs e)
        {
            if (Checksala.Checked)
            {
                combox1.Enabled = true;
                consutaSala();
            }
            else
            {
                combox1.Enabled = false;
                combox1.DataSource = null;
                consultaComplejos();
            }
            

        }
        public void buscarSala()
        {
            String idSala = "" + combox1.SelectedValue;
            SalasDTO s_DTO = new SalasDTO();
            try
            {
                s_DTO.Id_Tipo_Proyeccion = Int32.Parse(idSala);
                SalasDAO sal_dao = new SalasDAO();
                DataTable dt = sal_dao.salaBus(s_DTO);
                dataG.DataSource = dt;

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void combox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Checksala.Checked)
            {
                buscarSala();
            }
        }
    }

}
