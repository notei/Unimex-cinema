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
        }


    }
}
