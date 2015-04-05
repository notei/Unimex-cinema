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
    public partial class NewClientesFrecuentes : Form
    {
        private int id;
        Boolean isId = false;
        public NewClientesFrecuentes()
        {
            InitializeComponent();
            isId = true;
            btnCFNuevo.Text = "Nuevo";
        }
        public NewClientesFrecuentes(int id)
        {
            InitializeComponent();
            this.id = id;
            isId = false;
            btnCFNuevo.Text = "Actualizar";
        }
        private void btnCFNuevo_Click(object sender, EventArgs e)
        {
            if (isId)
            {
                ClientesFrecuentesDTO cfdto = new ClientesFrecuentesDTO();
                cfdto.Nombre = txtNombreNew.Text;
                cfdto.Apellido_Paterno = txtApellidoNew.Text;
                cfdto.User_Name = txtUserNew.Text;
                cfdto.Habilitado = chkHabilitadoNew.Checked;
                try
                {
                    ClientesFrecuentesDAO daoclientefrecuente = new ClientesFrecuentesDAO();
                    daoclientefrecuente.agregarClienteFrecuente(cfdto);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
                this.Dispose();
            }
            else
            {
                ClientesFrecuentesDTO cfdtoup = new ClientesFrecuentesDTO();
                cfdtoup.id_ClienteFrecuente = id;
                cfdtoup.Nombre = txtNombreNew.Text;
                cfdtoup.Apellido_Paterno = txtApellidoNew.Text;
                cfdtoup.User_Name = txtUserNew.Text;
                cfdtoup.Habilitado = chkHabilitadoNew.Checked;
                try
                {
                    ClientesFrecuentesDAO daocf1 = new ClientesFrecuentesDAO();
                    daocf1.updateCFrecuenteDTO(cfdtoup);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
                this.Dispose();
            }
        }
        public void cargarNewCFUpdate()
        {
            try
            {
                ClientesFrecuentesDAO cf_dao = new ClientesFrecuentesDAO();
                ClientesFrecuentesDTO cf_sdto = cf_dao.cargarCFUpdate(id);
                txtNombreNew.Text = cf_sdto.Nombre;
                txtApellidoNew.Text = cf_sdto.Apellido_Paterno;
                txtUserNew.Text = cf_sdto.User_Name;
                chkHabilitadoNew.Checked = cf_sdto.Habilitado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }
        private void btnCancelarNew_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void NewClientesFrecuentes_Load(object sender, EventArgs e)
        {
            if (isId)
            {
                ClientesFrecuentesDAO cffdao = new ClientesFrecuentesDAO();
                cffdao.cargarClientesFrecuentes();
            }
            else
            {
                cargarNewCFUpdate();
            }
        }
    }
}
