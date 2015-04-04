using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using unimex.lenguajesv.cine.DTO;
using unimex.lenguajesv.cine.DAO;

namespace unimex.lenguajesv.cine.Resources
{
    public partial class peliculas_estrenosfrm : Form
    {
        public peliculas_estrenosfrm()
        {
            InitializeComponent();
        }

        private void peliculas_estrenosfrm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            peliculas_estrenosDTO p = new peliculas_estrenosDTO();

            p.Id_estreno = (int)txtestreno.Value;
            p.Pelicula = txtpelicula.Text;
            p.Fecha_estreno = txtfecha.Text;



           peliculas_estrenosDAO dao = new peliculas_estrenosDAO();
            dao.insertaestrenos(p);

            this.Dispose();

        }
    }
}
