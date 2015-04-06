using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using unimex.lenguajesv.cine.DTO;
using unimex.lenguajesv.cine.DAO;

namespace unimex.lenguajesv.cine.views
{
    public partial class NewSalas : Form
    {
        public NewSalas()
        {
            InitializeComponent();
        }

        private void NewSalas_Load(object sender, EventArgs e)
        {
            consultaSonido();
            consultaProyeccion();

        }

        private void btnCa_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            new_Sala();
            this.Dispose();

        }
        public void new_Sala()
        {
            String idSonido = "" + salasCb.SelectedValue;
            SalasDTO sala_dto = new SalasDTO();
            sala_dto.Id_Complejo = Int32.Parse(txtCom.Text);
            sala_dto.Nombre_Sala = txtSala.Text;
            sala_dto.Capacidad = Int32.Parse(txtCap.Text);
            sala_dto.Butacas_Numeradas = Int32.Parse(txtBu.Text);
            sala_dto.Id_Tipo_Sonido = Int32.Parse(idSonido);
            sala_dto.Id_Tipo_Proyeccion = Int32.Parse(idSonido);
            try
            {
                SalasDAO sal_DAO = new SalasDAO();
                sal_DAO.newSalas(sala_dto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);

            }
        }
        private void consultaSonido()
        {
            SalasDAO Com_DAO = new SalasDAO();
            try
            {
                DataTable dt = Com_DAO.loadSonido();
                salasCb.DataSource = dt;
                salasCb.DisplayMember = "tipo_sonido";
                salasCb.ValueMember = "id_tipo_sonido";
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);

            }
        }
        private void consultaProyeccion()
        {
            SalasDAO Com_DAO = new SalasDAO();
            try
            {
                DataTable dt = Com_DAO.loadProyeccion();
                SalaCb2.DataSource = dt;
                SalaCb2.DisplayMember = "tipo_proyeccion";
                SalaCb2.ValueMember = "id_tipo_proyeccion";
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);

            }
        }
    }
}
