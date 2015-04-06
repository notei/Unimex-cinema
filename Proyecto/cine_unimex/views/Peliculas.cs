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
            DialogResult boton = MessageBox.Show("Desea Eliminar la Pelicula: " + reg + " con el precio: $" + regpelicula, "Borrar Registro", MessageBoxButtons.OKCancel);
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


    }
}
