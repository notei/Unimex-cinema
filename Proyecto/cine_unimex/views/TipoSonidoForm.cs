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
    public partial class TipoSonidoForm : Form
    {
        public TipoSonidoForm()
        {
            InitializeComponent();
        }

        private void TipoSonidoForm_Load(object sender, EventArgs e)
        {
            consultaDGVTipoSonido();
        }
        public void consultaDGVTipoSonido()
        {
            TipoSonidoDAO daoTipoSonido = new TipoSonidoDAO();
            DataTable dtn = daoTipoSonido.loadTipoSonido();
            dgvTipoSonido.DataSource = dtn;
            dgvTipoSonido.Columns[0].Visible = false;
        }
    }
}
