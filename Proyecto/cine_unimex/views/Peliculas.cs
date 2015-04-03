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
                    DataTable dt = Pel_DAO.LoadPeliculas();
                    peliculasdgv.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                
            }
        }


    }
}
