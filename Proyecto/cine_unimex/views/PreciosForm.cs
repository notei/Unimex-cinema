﻿using System;
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
    public partial class PreciosForm : Form
    {
        public PreciosForm()
        {
            InitializeComponent();
        }

        private void PreciosForm_Load(object sender, EventArgs e)
        {
            dgvPrecios.DefaultCellStyle.BackColor = Color.LightGray;
            dgvPrecios.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;
            consultaPrecios();
            consultaBuscarPrecios();
            queryBuscarPre();
            cbxPreciosBuscar.DataSource = null;
            cbxPreciosBuscar.Enabled = false;
            cbxPrecioBuscpre.DataSource = null;
            cbxPrecioBuscpre.Enabled = false;
        }

        public void consultaPrecios()
        {
            PreciosDAO daoPrecios = new PreciosDAO();
            DataTable dtp = daoPrecios.loadPrecios();
            dgvPrecios.DataSource=dtp;
            dgvPrecios.Columns[0].Visible = false;
        }
        public void consultaBuscarPrecios ()
        {
            PreciosDAO pre_dao = new PreciosDAO();
            try
            {
                DataTable dtbus = pre_dao.LoadNombrePrecio();
                cbxPreciosBuscar.DataSource = dtbus;
                cbxPreciosBuscar.DisplayMember = "nombre";
                cbxPreciosBuscar.ValueMember = "id_precio";
            }
            catch(Exception ex)
            {
                MessageBox.Show(""+ex);
            }
        }
        public void disposeNew(object Source, EventArgs args)
        {
            consultaPrecios();
        }
        public void queryBuscarPre()
        {
            PreciosDAO pre_dao = new PreciosDAO();
            try
            {
                DataTable dtbus = pre_dao.LoadPrecPrecio();
                cbxPrecioBuscpre.DataSource = dtbus;
                cbxPrecioBuscpre.DisplayMember = "precio";
                cbxPrecioBuscpre.ValueMember = "id_precio";
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        public void buscarPrecio ()
        {
            String idpreciobus = "" + cbxPreciosBuscar.SelectedValue;
            PreciosDTO precio_dto = new PreciosDTO();
            try
            {
                precio_dto.id_Precios = Int32.Parse(idpreciobus);
                PreciosDAO pre_dao = new PreciosDAO();
                DataTable dtbus1 = pre_dao.cargaBusquedaPrecio(precio_dto);
                dgvPrecios.DataSource = dtbus1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(""+ex);
            }
            

        }
        public void buscarPreciodelprecio ()
        {
            String idpreciobus = "" + cbxPrecioBuscpre.SelectedValue;
            PreciosDTO precio_dto = new PreciosDTO();
            try
            {
                precio_dto.id_Precios = Int32.Parse(idpreciobus);
                PreciosDAO pre_dao = new PreciosDAO();
                DataTable dtbus1 = pre_dao.cargaBusquedaPrecio(precio_dto);
                dgvPrecios.DataSource = dtbus1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }


        }
        private void btnAgregarprecio_Click(object sender, EventArgs e)
        {
            NewPrecios frmnew = new NewPrecios();
            frmnew.MdiParent = this.MdiParent;
            frmnew.Show();
            consultaPrecios();
        }

        private void btnActualizarPrecios_Click(object sender, EventArgs e)
        {
            int fil = dgvPrecios.CurrentCell.RowIndex;
            String valor = dgvPrecios.Rows[fil].Cells[0].Value.ToString();
            int id = Int32.Parse(valor);
            NewPrecios formaupdate = new NewPrecios(id);
            formaupdate.MdiParent = this.MdiParent;
            formaupdate.Show();
            consultaPrecios();
        }

        private void btnBorrarPrecio_Click(object sender, EventArgs e)
        {
            int fil = dgvPrecios.CurrentCell.RowIndex;
            String valor = dgvPrecios.Rows[fil].Cells[0].Value.ToString();
            int id2 = Int32.Parse(valor);
            String reg = dgvPrecios.Rows[fil].Cells[1].Value.ToString();
            String regprecio = dgvPrecios.Rows[fil].Cells[3].Value.ToString();
            DialogResult boton = MessageBox.Show("Desea Eliminar el Boleto: "+reg+" con el precio: $"+regprecio, "Borrar Registro", MessageBoxButtons.OKCancel);
            if (boton == DialogResult.OK)
            {
                
                PreciosDTO pdtoup = new PreciosDTO();
                pdtoup.id_Precios = id2;

                try
                {
                    PreciosDAO daoprecio1 = new PreciosDAO();
                    daoprecio1.deletePrecioDTO(pdtoup);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }                
                consultaPrecios();
            }
            else
            {
                
            }
        }

        private void checkPreciosbus_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPreciosbus.Checked)
            {
                cbxPreciosBuscar.Enabled = true;
                consultaBuscarPrecios();
            }
            else
            {
                cbxPreciosBuscar.Enabled = false;
                cbxPreciosBuscar.DataSource = null;
                consultaPrecios();
            }
        }

        private void cbxPreciosBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkPreciosbus.Checked)
            {
                buscarPrecio();
            }
        }

        private void checkPreciobolbus_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPreciobolbus.Checked)
            {
                cbxPrecioBuscpre.Enabled = true;
                queryBuscarPre();
            }
            else
            {
                cbxPrecioBuscpre.Enabled = false;
                cbxPrecioBuscpre.DataSource = null;
                consultaPrecios();
            }
        }

        private void cbxPrecioBuscpre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkPreciobolbus.Checked)
            {
                buscarPreciodelprecio();
            }
        }
            
    }
}
