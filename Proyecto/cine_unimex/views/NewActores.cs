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
            if (txtNombre.Text != "")
            {
                ActoresDTO  n = new ActoresDTO ();
                n.Nombre = txtNombre.Text ;
                n.ApellidoP = txtAP.Text;
                n.ApellidoM = txtAM.Text;
                n.Sexo = txtSexo.Text;
                NacionalidadesActoresDTO s = new NacionalidadesActoresDTO();
                s.Nacionalidad = cbxNacionalidad.Text;


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

