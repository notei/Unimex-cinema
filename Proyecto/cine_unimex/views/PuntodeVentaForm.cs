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
    public partial class PuntodeVentaForm : Form
    {
        private int id;
        private String nom;
        public PuntodeVentaForm(int id, String nom)
        {
            InitializeComponent();
            this.id = id;
            this.nom = nom;

        }




        public void buscarTipoBoletoPV()
        {
            PuntodeVentaBoletosDAO pre_dao = new PuntodeVentaBoletosDAO();
            try
            {
                DataTable dtbus = pre_dao.cargarTipoBoletoPV();
                cmbTipoBoletoPV.DataSource = dtbus;
                cmbTipoBoletoPV.DisplayMember = "nombre";
                cmbTipoBoletoPV.ValueMember = "id_precio";
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
            UsuarioDTO usuario = (UsuarioDTO)Sesion.getElement("USUARIO");
            this.Text += " - " + usuario.Nombre + "  " + usuario.ApellidPaterno + " - Complejo: " + nom;
            buscarTipoBoletoPV();
            consultaDgvPV();
            complejoDGV();
            buscarComplejoPV();


        }
        public void buscarComplejoPV()
        {
            PuntodeVentaBoletosDAO pre_dao = new PuntodeVentaBoletosDAO();
            try
            {
                DataTable dtbus = pre_dao.cargarComplejoPV();
                
                nom = "nombre";
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        
        public void consultaDgvPV()
        {
            PuntodeVentaBoletosDAO daoPrecios = new PuntodeVentaBoletosDAO();
            DataTable dtb = daoPrecios.cargarDgvPelicula();
            dgvPV.DataSource = dtb;

        }
        public void cargarNewPreciosUpdate()
        {
            try
            {
                PuntodeVentaBoletosDAO presdao = new PuntodeVentaBoletosDAO();
                PuntodeVentaBoletosDTO presdto = presdao.cargarComplejoPV(id);


            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }
        public void complejoDGV()
        {
            
            PuntodeVentaBoletosDTO precio_dto = new PuntodeVentaBoletosDTO();
            try
            {
                precio_dto.Id_Complejo = id;

                PuntodeVentaBoletosDAO pre_dao = new PuntodeVentaBoletosDAO();
                DataTable dtbus1 = pre_dao.cargadtg(precio_dto);
                dgvPV.DataSource = dtbus1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }


        }
        private void cmbComplejosPV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelarPV_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptarPV_Click(object sender, EventArgs e)
        {

        }
    }
}
