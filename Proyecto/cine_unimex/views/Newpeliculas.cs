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

        private void Newpeliculas_Load(object sender, EventArgs e)
        {

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
                    //actualiza
                }
        }
        public void newpeliculas()
        {
            PeliculasDTO peli_DTO = new PeliculasDTO();
            peli_DTO.Pelicula = texpeli.Text;
            peli_DTO.Duracion_min = Int32.Parse(texduracion.Text);
            peli_DTO.Sinopsis = texsinopsis.Text;
            peli_DTO.Idioma = texidioma.Text;
            peli_DTO.Sonido = texsonido.Text;
            peli_DTO.Estreno = Int32.Parse(texestreno.Text);

            try
            {
                PeliculasDAO peliDAO = new PeliculasDAO();
                peliDAO.Newpeliculas(peli_DTO);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }
    }
}