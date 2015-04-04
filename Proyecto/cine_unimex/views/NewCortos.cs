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
    public partial class NewCortos : Form
    {
        public NewCortos()
        {
            

            InitializeComponent();
        }

        private void NewCortos_Load(object sender, EventArgs e)
        {
            NuevosCortos();

        }

        private void cancelarbtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void aceptarbtn_Click(object sender, EventArgs e)
        {

        }

        public void NuevosCortos()
        {
            CortosDTO cortos_dto = new CortosDTO();
            cortos_dto.Id_Pelicula = Int32.Parse(idptxt.Text);
            cortos_dto.Nombre_Corto = nombrectxt.Text;
            cortos_dto.Duracion = Int32.Parse(duraciontxt.Text);
            cortos_dto.Habilitado = Int32.Parse(htxt.Text);

        }
    
    }
}
