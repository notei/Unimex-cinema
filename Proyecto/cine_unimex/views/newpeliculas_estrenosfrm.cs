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
using System.Resources;

namespace unimex.lenguajesv.cine.Resources
{
    public partial class peliculas_estrenosfrm : Form
    {
        private int id;
        Boolean isInsertid = false;
        private void peliculas_estrenosfrm_Load(object sender, EventArgs e)
        {

        }
       
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            peliculas_estrenosDTO p = new peliculas_estrenosDTO();

            p.Pelicula = Convert.ToString(cmbpelicula.SelectedValue);
            p.Fecha_estreno = Convert.ToString(Horario.DataBindings);
            p.Habilitado = checkBox1.Checked;


           peliculas_estrenosDAO dao = new peliculas_estrenosDAO();
            dao.insertaestrenos(p);

            this.Dispose();

        }
        private void newestrenos (object sender, EventArgs e)
        {
            if (isInsertid)
            {
                Horario.ShowUpDown = true;
                Horario.CustomFormat = "yyyy-MM-dd HH:mm";
                Horario.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
               
            } 
            else
            {
                Horario.ShowUpDown = true;
                Horario.CustomFormat = "yyyy-MM-dd HH:mm";
                Horario.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
                

            }
        }
        public peliculas_estrenosfrm()
        {
            InitializeComponent();
            isInsertid = true;
            btnAgregar.Text = "Agregar";
        }
        public peliculas_estrenosfrm(int id)
        {
            InitializeComponent();
            this.id = id;
            isInsertid = false;
            btnAgregar.Text = "Actualizar";
        } 
        private void txtpelicula_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
