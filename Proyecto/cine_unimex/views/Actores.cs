using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace unimex.lenguajesv.cine.views
{
    public partial class Actores : Form
    {
        public Actores()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NewActores agractores= new NewActores();
            agractores.ShowDialog();
        }

        private void Actores_Load(object sender, EventArgs e)
        {
            DataGridViewActores();
        }
        public void DataGridViewActores()
        {
            ActoresDAO dgvMostrar = new ActoresDAO();
            DataTable dtp = dgvMostrar.loadPrecios();
            dgvActores.DataSource = dtp;
            dgvActores.Columns[0].Visible = false;
        }
    }
}
