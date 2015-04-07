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
    public partial class PuntodeVentaDulceriaForm : Form
    {
        public PuntodeVentaDulceriaForm()
        {
            InitializeComponent();
        }


        public void seleccionarProductoPVD()
        {
            PuntodeVentaDulceriaDAO pre_dao = new PuntodeVentaDulceriaDAO();
            try
            {
                DataTable dtbus = pre_dao.seleccionarProductoPVD();
                cmbProductosPVD.DataSource = dtbus;
                cmbProductosPVD.DisplayMember = "nombre";
                cmbProductosPVD.ValueMember = "id_producto";
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        public void seleccionarCombosPVD()
        {
            PuntodeVentaDulceriaDAO pre_dao = new PuntodeVentaDulceriaDAO();
            try
            {
                DataTable dtbus = pre_dao.seleccionarCombosPVD();
                cmbCombosPVD.DataSource = dtbus;
                cmbCombosPVD.DisplayMember = "nombre";
                cmbCombosPVD.ValueMember = "id_combo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        private void PuntodeVentaDulceriaForm_Load(object sender, EventArgs e)
        {
            seleccionarProductoPVD();
            seleccionarCombosPVD();


        }

        
    }
}
