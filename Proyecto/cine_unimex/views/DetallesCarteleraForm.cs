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
    public partial class DetallesCarteleraForm : Form
    {
        private int id;
        public DetallesCarteleraForm(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void DetallesCarteleraForm_Load(object sender, EventArgs e)
        {
            consultaDetallesCartelera();
        }
        public void consultaDetallesCartelera()
        {
            CarteleraDAO daocartelera = new CarteleraDAO();
            DataTable dtp = daocartelera.cargarDetallesCart(id);
            dgvDetallesCartelera.DataSource = dtp;
            dgvDetallesCartelera.Columns[0].Visible = false;

        }
    }
}
