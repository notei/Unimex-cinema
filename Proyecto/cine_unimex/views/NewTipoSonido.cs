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
    public partial class NewTipoSonido : Form
    {
        private int id;
        Boolean estaId = false;
        public NewTipoSonido()
        {
            InitializeComponent();
            estaId = true;
            btnNuevoNew.Text = "Nuevo";
        }
        public NewTipoSonido(int id)
        {
            InitializeComponent();
            this.id = id;
            estaId = false;
            btnNuevoNew.Text = "Actualizar";
        }
        private void btnNuevoNew_Click(object sender, EventArgs e)
        {
            if (estaId)
            {
                TipoSonidoDTO tpdto = new TipoSonidoDTO();
                tpdto.tipoSonido = txtTipoSonidoNew.Text;
                tpdto.Descripcion = txtDescripcionNew.Text;
                tpdto.Habilitado = chkHabilitadoNew.Checked;
                try
                {
                    TipoSonidoDAO daoTP = new TipoSonidoDAO();
                    daoTP.agregarTipoSonido(tpdto);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
                this.Dispose();
            }
            else
            {
                TipoSonidoDTO tpdtoup = new TipoSonidoDTO();
                tpdtoup.id_TipoSonido = id;
                tpdtoup.tipoSonido = txtTipoSonidoNew.Text;
                tpdtoup.Descripcion = txtDescripcionNew.Text;
                tpdtoup.Habilitado = chkHabilitadoNew.Checked;
                try
                {
                    TipoSonidoDAO daoprecio1 = new TipoSonidoDAO();
                    daoprecio1.updateTipoSonidoDTO(tpdtoup);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
                this.Dispose();
            }
        }

        private void NewTipoSonido_Load(object sender, EventArgs e)
        {
            if (estaId)
            {
                TipoSonidoDAO daosonido = new TipoSonidoDAO();
                daosonido.loadTipoSonido();
            }
            else
            {
                cargarNewTsonidoUpdate();
            }
        }
        public void cargarNewTsonidoUpdate()
        {
            try
            {
                TipoSonidoDAO TSdao = new TipoSonidoDAO();
                TipoSonidoDTO presdto = TSdao.cargarTSonidoUpdate(id);
                txtTipoSonidoNew.Text = presdto.tipoSonido;
                txtDescripcionNew.Text = presdto.Descripcion;
                chkHabilitadoNew.Checked = presdto.Habilitado;
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
    }
}
