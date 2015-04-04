using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace unimex.lenguajesv.cine
{
    public partial class VentasTotales : Form
    {
        public VentasTotales()
        {
            InitializeComponent();
        }

        private void VentasTotales_Load(object sender, EventArgs e)
        {
            vetasTotalesDGV();
            
        }

        public void vetasTotalesDGV()
        {
            totalVentaBoletosyPorComplejoDAO dgvMostrar = new totalVentaBoletosyPorComplejoDAO();
            DataTable dtp = dgvMostrar.LoadTotal();
            dgvVentasBoletos.DataSource = dtp;
            dgvVentasBoletos.Columns[0].Visible = false;
        }

       
    }
}
