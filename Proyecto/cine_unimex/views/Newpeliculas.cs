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
    public partial class Newpeliculas : Form
    {
        private int id;
        Boolean isInsertid = false;

        public Newpeliculas()
        {
            InitializeComponent();
            isInsertid = true;
            btacept.Text = "Agregar";
        }
        public Newpeliculas(int id)
        {
            InitializeComponent();
            this.id = id;
            isInsertid = false;
            btacept.Text = "Actualizar";
        }
        public void cargarNewCFUpdate()
        {
            try
            {
                PeliculasDAO cf_dao = new PeliculasDAO();
                PeliculasDTO cf_sdto = cf_dao.LoadPeliculas(id);
                texpeli.Text = cf_sdto.Pelicula;
                texduracion.Text = Convert.ToString(cf_sdto.Duracion_min);
                texsinopsis.Text = cf_sdto.Sinopsis;
                texidioma.Text = cf_sdto.Idioma;
                texsonido.Text = cf_sdto.Sonido;
                chec.Checked = cf_sdto.Estreno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        

        private void Newpeliculas_Load(object sender, EventArgs e)
        {
            consultarIdclasifiacion();
            consultarIdNac();
            consultarIdgenero();
            cargarNewCFUpdate();
        }
        public void consultarIdclasifiacion()
        {
            PeliculasDAO P_DAO = new PeliculasDAO();

            try
            {
                DataTable dt = P_DAO.Loadidclasificacion();
                cmbidClasificacionNew.DataSource = dt;
                cmbidClasificacionNew.DisplayMember = "id_clasificacion";
                cmbidClasificacionNew.ValueMember = "id_clasificacion";
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        public void consultarIdNac()
        {
            PeliculasDAO P_DAO = new PeliculasDAO();

            try
            {
                DataTable dt = P_DAO.Loadidnacionalidad();
                cmbNacioPeliNew.DataSource = dt;
                cmbNacioPeliNew.DisplayMember = "id_nacionalidad";
                cmbNacioPeliNew.ValueMember = "id_nacionalidad";
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        public void queryPelicula()
        {
            PeliculasDAO pregg = new PeliculasDAO();
            try
            {
                DataTable dtdd = pregg.loadPeliculas();
                
            }
            catch (Exception ex)
            { 
            
            }
        }
        public void consultarIdgenero()
        {
            PeliculasDAO P_DAO = new PeliculasDAO();

            try
            {
                DataTable dt = P_DAO.Loadidgenero();
                cmbPelicGenero.DataSource = dt;
                cmbPelicGenero.DisplayMember = "id_genero";
                cmbPelicGenero.ValueMember = "id_genero";
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        private void btcancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        
    
        private void btacept_Click(object sender, EventArgs e)
        {
            if (isInsertid)
            {

                newpeliculas();
                    this.Dispose();
            }
            else
            {
                String idclass = "" + cmbidClasificacionNew.SelectedValue;
                String idnacc = "" + cmbNacioPeliNew.SelectedValue;
                String idgene = "" + cmbPelicGenero.SelectedValue;
                PeliculasDTO cfdtoup = new PeliculasDTO();
                cfdtoup.id_Pelicula = id;
                cfdtoup.Pelicula = texpeli.Text;
                cfdtoup.id_Clasificacion = Int32.Parse(idclass);
                cfdtoup.Duracion_min = Int32.Parse(texduracion.Text);
                cfdtoup.Sinopsis = texsinopsis.Text;
                cfdtoup.Idioma = texidioma.Text;
                cfdtoup.Sonido = texsonido.Text;
                cfdtoup.id_Nacionalidad = Int32.Parse(idnacc);
                cfdtoup.id_Genero = Int32.Parse(idgene);
                cfdtoup.Estreno = chec.Checked;
                try
                {
                    PeliculasDAO daocf1 = new PeliculasDAO();
                    daocf1.updateCFrecuenteDTO(cfdtoup);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
                this.Dispose();
            }
        }
        public void newpeliculas()
        {
            String idcalsificacion = "" + cmbidClasificacionNew.SelectedValue;
            String idnacio = "" + cmbNacioPeliNew.SelectedValue;
            String idgeneropel = "" + cmbPelicGenero.SelectedValue;
            PeliculasDTO peli_DTO = new PeliculasDTO();
            peli_DTO.id_Clasificacion = Int32.Parse(idcalsificacion);
            peli_DTO.id_Nacionalidad = Int32.Parse(idnacio);
            peli_DTO.id_Genero = Int32.Parse(idgeneropel);
            peli_DTO.Pelicula = texpeli.Text;
            peli_DTO.Duracion_min = Int32.Parse(texduracion.Text);
            peli_DTO.Sinopsis = texsinopsis.Text;
            peli_DTO.Idioma = texidioma.Text;
            peli_DTO.Sonido = texsonido.Text;
            peli_DTO.Estreno = chec.Checked;

            try
            {
                PeliculasDAO peliDAO = new PeliculasDAO();
                peliDAO.NewPeliculasotro(peli_DTO);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}