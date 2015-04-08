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
    public partial class NewTipoproyeccion : Form
    {
        private int id;
        Boolean conocerId=false;
        public NewTipoproyeccion()
        {
            InitializeComponent();
            conocerId = true;
            btnAgregar.Text = "Agregar";
        }
        public NewTipoproyeccion(int id)
        {
            InitializeComponent();
            this.id = id;
            conocerId = false;
            btnAgregar.Text = "Actualizar";
        }
        private void button3_Click(object sender, EventArgs e)
        {
           
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void NewTipoProyeccion_Load(object sender, EventArgs e)
        {
            if (conocerId)
            {
                TipoProyeccionDAO pr = new TipoProyeccionDAO();
                pr.loadTipoProyeccion();
            }
            else
            {
                cargarNewTPUpdate();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (conocerId)
            {
                TipoProyeccionDTO tpdto = new TipoProyeccionDTO();
                tpdto.tipoProyeccion = txtTipoproyeccion.Text;
                tpdto.Descripcion = txtDescripcion.Text;
                tpdto.Habilitado = checkHabilitado.Checked;
                try
                {
                    TipoProyeccionDAO daoTP = new TipoProyeccionDAO();
                    daoTP.agregarTipoproyeccion(tpdto);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
                this.Dispose();
            }
            else
            {
                TipoProyeccionDTO tpdtoup = new TipoProyeccionDTO();
                tpdtoup.id_TipoProyeccion = id;
                tpdtoup.tipoProyeccion = txtTipoproyeccion.Text;
                tpdtoup.Descripcion = txtDescripcion.Text;
                tpdtoup.Habilitado = checkHabilitado.Checked;
                try
                {
                    TipoProyeccionDAO daoprecio1 = new TipoProyeccionDAO();
                    daoprecio1.updateTipoProyeccionDTO(tpdtoup);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
                this.Dispose();
            }
        }
        public void cargarNewTPUpdate()
        {
            try
            {
                TipoProyeccionDAO TPdao = new TipoProyeccionDAO();
                TipoProyeccionDTO presdto = TPdao.cargarTPUpdate(id);
                txtTipoproyeccion.Text = presdto.tipoProyeccion;
                txtDescripcion.Text = presdto.Descripcion;
                checkHabilitado.Checked = presdto.Habilitado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        
        }
    }

