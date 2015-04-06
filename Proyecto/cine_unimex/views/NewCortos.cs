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
        private int id;
        Boolean isInsertId = false;

        public NewCortos()
        {
            

            InitializeComponent();
            isInsertId = true;
            aceptarbtn.Text = "Agregar";
        }

        public NewCortos(int id)
        {


            InitializeComponent();
            this.id = id;
            isInsertId = false;
            aceptarbtn.Text = "Actalizarr";
        }

        private void NewCortos_Load(object sender, EventArgs e)
        {
            if (isInsertId)
            {
                
               


            }

            else

            {
                LoadCortos();
            }

        }

        private void cancelarbtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void aceptarbtn_Click(object sender, EventArgs e)
        {
            if (isInsertId)
            {
                NuevosCortos();
                this.Dispose();
            }
            else
            {
                //actualizar
            }

            
        }
        //Método LoadCortos

        public void LoadCortos()
        {
            try
            {
                CortosDAO cortos_dao = new CortosDAO();
                CortosDTO corto_dto = cortos_dao.LoadCortos(id);
                cortos_dao.newCortos(corto_dto);
                nombrectxt.Text = corto_dto.Nombre_Corto;
                idptxt.Text = Convert.ToString(corto_dto.Id_Pelicula);
                duraciontxt.Text = Convert.ToString(corto_dto.Duracion);
                check.Checked = corto_dto.Habilitado;

            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            

            
        }

        public void NuevosCortos()
        {
            CortosDTO cortos_dto = new CortosDTO();
            cortos_dto.Id_Pelicula = Int32.Parse(idptxt.Text);
            cortos_dto.Nombre_Corto = nombrectxt.Text;
            cortos_dto.Duracion = Int32.Parse(duraciontxt.Text);
            cortos_dto.Habilitado = check.Checked;

            try
            {
                CortosDAO cortos_dao = new CortosDAO();
                CortosDTO corto_dto = cortos_dao.LoadCortos(id);
                cortos_dao.newCortos(corto_dto);

            }

            catch (Exception ex)
            {
                MessageBox.Show(""+ex);
            }

        }
    
    }
}
