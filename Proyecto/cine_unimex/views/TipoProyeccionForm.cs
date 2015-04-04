﻿using System;
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
    public partial class TipoProyeccionForm : Form
    {
        public TipoProyeccionForm()
        {
            InitializeComponent();
        }

        private void TipoProyeccionForm_Load(object sender, EventArgs e)
        {
            consutaNacinalidades();
        }
        public void consutaNacinalidades()
        {
            TipoProyeccionDAO daoTipoProyeccion = new TipoProyeccionDAO();
            DataTable dtn = daoTipoProyeccion.loadTipoProyeccion();
            dtgTipoProyeccion.DataSource = dtn;
            dtgTipoProyeccion.Columns[0].Visible = false;
        }
    }
}