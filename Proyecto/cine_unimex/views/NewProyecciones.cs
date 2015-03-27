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
    public partial class NewProyecciones : Form
    {
        public NewProyecciones()
        {
            InitializeComponent();
        }

        private void NewProyecciones_Load(object sender, EventArgs e)
        {
            Horario.ShowUpDown = true;
            Horario.CustomFormat = "yyyy-MM-dd HH:mm";
            Horario.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        }
        public void newproyecciones()
        {

            ProyeccionesDTO proy_dto = new ProyeccionesDTO();
            proy_dto.idsala = Int32.Parse(idsalaTXT.Text);
            proy_dto.idpelicula = Int32.Parse(idpeliculaTXT.Text);
            // captura incorrecta en la fecha verificar conversión de date a text 
            proy_dto.fechas = Horario.Text;
            label1.Text = Horario.Text;
            try
            {
                ProyeccionesDAO proy_dao = new ProyeccionesDAO();
                proy_dao.newProyeccion(proy_dto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void acceptbtn_Click(object sender, EventArgs e)
        {
            newproyecciones();
            
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        
        }
    }

