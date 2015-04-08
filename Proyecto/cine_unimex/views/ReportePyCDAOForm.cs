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
    public partial class ReportePyCDAOForm : Form
    {
        public ReportePyCDAOForm()
        {
            InitializeComponent();
        }

        private void ReportePyCDAOForm_Load(object sender, EventArgs e)
        {
            Reporte_Ventas();
        }

        public void Reporte_Ventas()
        {
            ReportePyCDAO R_DAO = new ReportePyCDAO();

            try
            {
                DataTable dt = R_DAO.Ventas_Pelicula_Complejo();
                reporteDgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
    }
}
