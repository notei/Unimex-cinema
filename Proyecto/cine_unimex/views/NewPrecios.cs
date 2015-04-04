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
    public partial class NewPrecios : Form
    {
        private int id;
        Boolean insertId = false;
        public NewPrecios()
        {
            InitializeComponent();
            insertId = true;
            btnAgregarnew.Text = "Agregar";
        }
        public NewPrecios(int id)
        {
            InitializeComponent();
            this.id = id;
            insertId = false;
            btnAgregarnew.Text = "Actualizar";
        }
        private void btnAgregarnew_Click(object sender, EventArgs e)
        {
            if (insertId)
            {
                if (txtNombrenew.Text != "" && txtDescnew.Text != "" && txtPrecionew.Text != "")
                {
                    PreciosDTO pdto = new PreciosDTO();
                    pdto.Nombre = txtNombrenew.Text;
                    pdto.Descripcion = txtDescnew.Text;
                    pdto.Precios = float.Parse(txtPrecionew.Text);
                    try
                    {
                        PreciosDAO daoprecio = new PreciosDAO();
                        daoprecio.agregarPrecio(pdto);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                }
                else
                {
                    MessageBox.Show("Ingresa Nombre, Descripcion y precio para poder guardar el registro!!!");
                }
                this.Dispose();
            }
            else
            {
              
                //Programar Actualizar
            }
        }
        public void loadPreciosActualizar()
        {
            try
            {
                PreciosDAO preciodao = new PreciosDAO();
                PreciosDTO preciodto = preciodao.cargarPreciosconsulta(id);
                txtNombrenew.Text = preciodto.Nombre;
                txtDescnew.Text = preciodto.Descripcion;
                txtPrecionew.Text = Convert.ToString(preciodto.Precios);
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
           
        }
        private void btnCancelarnew_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void NewPrecios_Load(object sender, EventArgs e)
        {
            if (insertId)
            {
                PreciosDAO predao = new PreciosDAO();
                predao.loadPrecios();
            }
            else
            {
                
                loadPreciosActualizar();
            }
        }
    }
}
