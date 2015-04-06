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
        public NewTipoSonido()
        {
            InitializeComponent();
        }

        private void btnNuevoNew_Click(object sender, EventArgs e)
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

        private void NewTipoSonido_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelarNew_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
