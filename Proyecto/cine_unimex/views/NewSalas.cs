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
            SalasDTO sala_dto = new SalasDTO();
            sala_dto.Id_Complejo = Int32.Parse(txtCom.Text);
            sala_dto.Nombre_Sala = txtSala.Text;
            sala_dto.Capacidad = Int32.Parse(txtCap.Text);
            sala_dto.Butacas_Numeradas = Int32.Parse(txtBu.Text);
            sala_dto.Id_Tipo_Sonido = Int32.Parse(txtSoni.Text);
            sala_dto.Id_Tipo_Proyeccion = Int32.Parse(txtProyec.Text);
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
    }
}
