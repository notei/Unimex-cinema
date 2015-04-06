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
    public partial class NewNacionalidades : Form

    {
        private int id;
        Boolean idb = false;

        public NewNacionalidades()
        {
            InitializeComponent();
            idb = true;
            btnAceptar.Text = "Agregar";
            
        }

        public NewNacionalidades(int id)
        {
            InitializeComponent();
            this.id = id;
            btnAceptar.Text = "Actualizar";
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (idb)
            {
                if (txtNewNacionalidad.Text != "")
                {
                    NacionalidadesDTO n = new NacionalidadesDTO();
                    n.Nacionalidad = txtNewNacionalidad.Text;
                    n.Habilitado = chkHabilitado.Checked;


                    try
                    {
                        NacionalidadesDAO dao = new NacionalidadesDAO();
                        dao.agregarNacionalidad(n);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }

                }

                else
                {
                    MessageBox.Show(" Ingrese una nacionalidad ", " ERROR");
                }
                this.Dispose();
            }
            else
            {
                //Program Act
               
                NacionalidadesDTO naup = new NacionalidadesDTO();
                naup.id_Nacionalidad = id;
                naup.Nacionalidad = txtNewNacionalidad.Text;
                naup.Habilitado = chkHabilitado.Checked;
                                    
                try
                {
                    NacionalidadesDAO newdao = new NacionalidadesDAO();
                    newdao.updateNacionalidadesDTO(naup);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
                this.Dispose();
            }
        }
        public void cargarNewNacionalidadUpdate()
        {
            try
            {
                NacionalidadesDAO nadao = new NacionalidadesDAO ();
                NacionalidadesDTO nadto = nadao.cargarNacionalidadUpdate(id);
                txtNewNacionalidad.Text = nadto.Nacionalidad;
                chkHabilitado.Checked = nadto.Habilitado;

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }
        private void NewNacionalidades_Load(object sender, EventArgs e)
        {
            if (idb)
            {
                NacionalidadesDAO nacup = new NacionalidadesDAO();
                nacup.loadNacionalidades();
            }
            else
            {
                cargarNewNacionalidadUpdate();
            }
        }

        private void txtNewNacionalidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkHabilitado_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
