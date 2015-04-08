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
            consultaPeliculas();
            buscarPeliculaCB.DataSource = null;
            buscarPeliculaCB.Enabled = false;
            
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
            frmNewProy.MdiParent = this.MdiParent;
            frmNewProy.Show();
            frmNewProy.Disposed += new EventHandler(disposeNew);
            
           
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            int fila = ProyeccionesDgv.CurrentCell.RowIndex;
            String valor = ProyeccionesDgv.Rows[fila].Cells[0].Value.ToString();
            int id = Int32.Parse(valor);
            NewProyecciones frmNewProy = new NewProyecciones(id);
            frmNewProy.MdiParent = this.MdiParent;
            frmNewProy.Show();
            frmNewProy.Disposed += new EventHandler(disposeNew);

        }

        public void consultaPeliculas()
        {
            ProyeccionesDAO P_DAO = new ProyeccionesDAO();

            try
            {
                
                DataTable dt = P_DAO.Loadpeliculas();
                buscarPeliculaCB.DataSource = dt;
                buscarPeliculaCB.DisplayMember = "pelicula";
                buscarPeliculaCB.ValueMember = "id_pelicula";
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            
        }

        private void peliChb_CheckedChanged(object sender, EventArgs e)
        {
            if (peliChb.Checked)
            {
                buscarPeliculaCB.Enabled = true;
                consultaPeliculas();
            }
            else
            {
                buscarPeliculaCB.Enabled = false;
                buscarPeliculaCB.DataSource = null;
                consultaProyecciones();
            }
        }

        public void buscarPelicula()
        {
            String idpelicula = "" + buscarPeliculaCB.SelectedValue;
            ProyeccionesDTO p_DTO = new ProyeccionesDTO();
            try
            {
                
                p_DTO.idpelicula = Int32.Parse(idpelicula);
                ProyeccionesDAO proy_dao = new ProyeccionesDAO();
                DataTable dt = proy_dao.findPeliculas(p_DTO);
                ProyeccionesDgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

            
        }

        private void buscarPeliculaCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (peliChb.Checked)
            {
                buscarPelicula();
            }
            


        }

        

        
    }
}
