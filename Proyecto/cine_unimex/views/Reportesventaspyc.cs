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
    public partial class ReportesventaspypDAO : Form
    {
        public ReportesventaspypDAO()
        {
            InitializeComponent();
        }
            
        private void Reportesventaspyc_Load(object sender, EventArgs e)
        { 
            Reporte_Ventas();
        }

        public void Reporte_Ventas()
        {
            ReportesventaspypDAO RVP = new ReportesventaspypDAO();

            try
            {
                DataTable dt = RVP.Venta_Producto();
                dgvReporte.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private DataTable Venta_Producto()
        {
            throw new NotImplementedException();
        }
    }
}
