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
using unimex.lenguajesv.cine.Resources;


namespace unimex.lenguajesv.cine.views
{
    public partial class peliculas_estrenos : Form
    {
        public peliculas_estrenos()
        {
            InitializeComponent();
        }

        private void newpeliculas_estrenos_Load(object sender, EventArgs e)
        {
            peliculas_estrenosDAO dao = new peliculas_estrenosDAO();
            DataTable dt = dao.cargardatos();
            dataGrid.DataSource = dt;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            peliculas_estrenosfrm form = new peliculas_estrenosfrm();
            form.ShowDialog();
           

        }
    }
}
