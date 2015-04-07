using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using unimex.lenguajesv.cine.DAO;

namespace unimex.lenguajesv.cine.views
{
    public partial class PuntodeVentaForm : Form
    {
        public PuntodeVentaForm()
        {
            InitializeComponent();
        }

        public void buscarComplejoPV ()
        {
            PuntodeVentaBoletosDAO pre_dao = new PuntodeVentaBoletosDAO();
            try
            {
                DataTable dtbus = pre_dao.cargarComplejoPV();
                cmbComplejosPV.DataSource = dtbus;
                cmbComplejosPV.DisplayMember = "nombre";
                cmbComplejosPV.ValueMember = "id_complejo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        public void buscarPeliculaPV()
        {
            PuntodeVentaBoletosDAO pre_dao = new PuntodeVentaBoletosDAO();
            try
            {
                DataTable dtbus = pre_dao.cargarPeliculaPV();
                cmbPeliculaPV.DataSource = dtbus;
                cmbPeliculaPV.DisplayMember = "pelicula";
                cmbPeliculaPV.ValueMember = "id_pelicula";
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        public void buscarSalaPV()
        {
            PuntodeVentaBoletosDAO pre_dao = new PuntodeVentaBoletosDAO();
            try
            {
                DataTable dtbus = pre_dao.cargarSalaPV();
                cmbSalaPV.DataSource = dtbus;
                cmbSalaPV.DisplayMember = "Sala";
                cmbSalaPV.ValueMember = "nombre_sala";
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void PuntodeVentaForm_Load(object sender, EventArgs e)
        {
            buscarComplejoPV();
            buscarPeliculaPV();
            buscarSalaPV();

        }

        private void cmbComplejosPV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
