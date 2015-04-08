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
    public partial class CarteleraForm : Form
    {
        public CarteleraForm()
        {
            InitializeComponent();
        }

        private void CarteleraForm_Load(object sender, EventArgs e)
        {
            consultaCartelera();
        }
        public void consultaCartelera()
        {
            CarteleraDAO daocartelera = new CarteleraDAO();
            DataTable dtp = daocartelera.consultaCartelera();
            dgvCartelera.DataSource = dtp;
            
        }
    }
}
