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
    public partial class NewActores : Form
    {
        public NewActores()
        {
            InitializeComponent();
        }

        private void btnAregarNew_Click(object sender, EventArgs e)
        {
            ActoresDTO n = new ActoresDTO();
            
            if (txtNombre.Text != "")
            {
                if (mascRb.Checked)
                {
                    n.Nombre = txtNombre.Text;
                    n.ApellidoP = txtAP.Text;
                    n.ApellidoM = txtAM.Text;
                    n.Sexo = 1;
                    //NacionalidadesActoresDTO s = new NacionalidadesActoresDTO();
                    n.Id_Nacionalidad = 1;// jalar el id nacionalidad del combo box 
                }
                else if (femRb.Checked)
                {
                    
                    n.Nombre = txtNombre.Text;
                    n.ApellidoP = txtAP.Text;
                    n.ApellidoM = txtAM.Text;
                    n.Sexo = 1;
                    //NacionalidadesActoresDTO s = new NacionalidadesActoresDTO();
                    n.Id_Nacionalidad = 2;// jalar el id nacionalidad del combo box 
                }
                else
                {
                    MessageBox.Show("Por favor selecciona si el actor es hombre o mujer.");
                }
                


                try
                {
                    ActoresDAO  dao = new ActoresDAO ();
                    dao.Actoragregar(n);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }

            }

            else
            {
                MessageBox.Show(" Ingrese un Actor ", " ERROR");
            }
            this.Dispose();
        }

        private void btnCancelarNew_Click(object sender, EventArgs e)
        {
             this.Dispose();
        }
        public void consultaNacionalidad()
        {
            ActoresDAO A_DAO = new ActoresDAO();

            try
            {
                DataTable dt = A_DAO.nacionalidadescbx();
                cbxNacionalidad.DataSource = dt;
                cbxNacionalidad.DisplayMember = "nacionalidad";
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void NewActores_Load(object sender, EventArgs e)
        {
            consultaNacionalidad();
        }
        
        }
    }

