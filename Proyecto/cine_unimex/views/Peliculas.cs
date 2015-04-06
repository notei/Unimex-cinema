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
    public partial class Peliculas : Form
    {
        public Peliculas()
        {
            InitializeComponent();
        }

        private void Peliculas_Load(object sender, EventArgs e)
        {
            consultaPeliculas();
        }

        public void consultaPeliculas()
        
            {
                PeliculasDAO Pel_DAO = new PeliculasDAO();

                try
                {
                    DataTable dt = Pel_DAO.loadPeliculas();
                    peliculasdgv.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                
            }
        }
        public void consultaViewCF()
        {
            PeliculasDAO daoClientesFrecuentes = new PeliculasDAO();
            DataTable dtp = daoClientesFrecuentes.loadPeliculas();
            peliculasdgv.DataSource = dtp;
            peliculasdgv.Columns[0].Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Newpeliculas frmNewProy = new Newpeliculas();
            frmNewProy.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fil = peliculasdgv.CurrentCell.RowIndex;
            String valor = peliculasdgv.Rows[fil].Cells[0].Value.ToString();
            int id = Int32.Parse(valor);
            Newpeliculas frmNewProy = new Newpeliculas(id);
            frmNewProy.Show();
            consultaPeliculas();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int fil = peliculasdgv.CurrentCell.RowIndex;
            String valor = peliculasdgv.Rows[fil].Cells[0].Value.ToString();
            int id2 = Int32.Parse(valor);
            String reg = peliculasdgv.Rows[fil].Cells[1].Value.ToString();
            String regpelicula = peliculasdgv.Rows[fil].Cells[3].Value.ToString();
            DialogResult boton = MessageBox.Show("Desea Eliminar la Pelicula: " + reg + " con la pelicula: $" + regpelicula, "Borrar Registro", MessageBoxButtons.OKCancel);
            if (boton == DialogResult.OK)
            {

                PeliculasDTO pdtoup = new PeliculasDTO();
                pdtoup.id_Pelicula = id2;

                try
                {
                    PeliculasDAO daopelis = new PeliculasDAO();
                    daopelis.deletepeliculasDTO(pdtoup);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
                consultaPeliculas();
            }
            else
            {

            }
        }

        private void checNombreCF_CheckedChanged(object sender, EventArgs e)
       
            {
                if (checNombreCF.Checked)
                {
                    cmbNombreCF.Enabled = true;
                    consultaBuscarNombreCF();
                }
                else
                {
                    cmbNombreCF.Enabled = false;
                    cmbNombreCF.DataSource = null;
                    consultaPeliculas();
                }
            }
        public void buscarNombreCF()
        {
            String id_Pelicula = "" + cmbNombreCF.SelectedValue;
            PeliculasDTO cf_dto = new PeliculasDTO();
            try
            {
                cf_dto.id_Pelicula = Int32.Parse(id_Pelicula);
                PeliculasDAO cf_dao = new PeliculasDAO();
                DataTable dtbus2 = cf_dao.cargaBusquedaCF(cf_dto);
                peliculasdgv.DataSource = dtbus2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }


        }

        public void consultaBuscarNombreCF()
        {
            PeliculasDAO precf_dao = new PeliculasDAO();
            try
            {
                DataTable dtbus = precf_dao.LoadNombreCF();
                cmbNombreCF.DataSource = dtbus;
                cmbNombreCF.DisplayMember = "pelicula";
                cmbNombreCF.ValueMember = "id_Pelicula";
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        private void cmbNombreCF_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checNombreCF.Checked)
            {
                buscarNombreCF();
            }
        }
        


    }
}
