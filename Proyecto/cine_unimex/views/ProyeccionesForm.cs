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
    public partial class ProyeccionesForm : Form
    {
        
        public ProyeccionesForm()
        {
            InitializeComponent();
        }

        private void ProyeccionesForm_Load(object sender, EventArgs e)
        {

            ProyeccionesDgv.DefaultCellStyle.BackColor = Color.LightGray;
            ProyeccionesDgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;
            consultaProyecciones();
            
        }
        
        public void consultaProyecciones()
        {
            ProyeccionesDAO P_DAO = new ProyeccionesDAO();

            try
            {
                DataTable dt = P_DAO.LoadProyecciones();
                ProyeccionesDgv.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        public void disposeNew(object Source, EventArgs args)
        {
            consultaProyecciones();
        }
        private void NewProy_Click(object sender, EventArgs e)
        {
            NewProyecciones frmNewProy = new NewProyecciones();
            frmNewProy.Show();
            frmNewProy.Disposed += new EventHandler(disposeNew);
           
        }

    }
}
