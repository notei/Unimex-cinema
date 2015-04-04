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
        private int id;
        Boolean isInsertId = false;
        public NewProyecciones()
        {
            InitializeComponent();
            isInsertId = true;
            acceptbtn.Text = "Agregar";
            label5.Text = "Nueva Proyección";
            label5.Location = new Point(6, 9); 
            this.Text = "Nueva Proyección";
        }
        public NewProyecciones(int id)
        {
            InitializeComponent();
            this.id = id;
            isInsertId = false;
            acceptbtn.Text = "Actualizar";
            label5.Text = "Actualizar ";
            label5.Location = new Point(71, 9); 
            this.Text = "Actualizar";
        }

        private void NewProyecciones_Load(object sender, EventArgs e)
        {
            if (isInsertId)
            {
                Horario.ShowUpDown = true;
                Horario.CustomFormat = "yyyy-MM-dd HH:mm";
                Horario.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
                consultaPeliculas();
                consultaComplejos();
                consultaSalas();
                complejosCb.SelectedIndexChanged += new EventHandler(ComboChange);
            }
            else
            {
                Horario.ShowUpDown = true;
                Horario.CustomFormat = "yyyy-MM-dd HH:mm";
                Horario.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
                consultaComplejos();
                consultaPeliculas();
                consultaSalas();
                LoadupdateProyecciones();
                complejosCb.SelectedIndexChanged += new EventHandler(ComboChange);
                
            }
            
        }

        public void consultaPeliculas()
        {
            ProyeccionesDAO P_DAO = new ProyeccionesDAO();

            try
            {
                DataTable dt = P_DAO.Loadpeliculas();
                peliculaCb.DataSource = dt;
                peliculaCb.DisplayMember = "pelicula";
                peliculaCb.ValueMember = "id_pelicula";
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        public void consultaComplejos()
        {
            ProyeccionesDAO P_DAO = new ProyeccionesDAO();

            try
            {
                DataTable dt = P_DAO.LoadComplejos();
                complejosCb.DataSource = dt;
                complejosCb.DisplayMember = "nombre";
                complejosCb.ValueMember = "id_complejo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        public void consultaSalas()
        {
            ProyeccionesDAO P_DAO = new ProyeccionesDAO();

            try
            {
                DataTable dt = P_DAO.LoadSalas(Int32.Parse("" + complejosCb.SelectedValue));
                salasCB.DataSource = dt;
                salasCB.DisplayMember = "nombre_sala";
                salasCB.ValueMember = "id_sala";
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        public void newproyecciones()
        {
            String idpelicula = "" + peliculaCb.SelectedValue;
            String idSala = "" + salasCB.SelectedValue;

            ProyeccionesDTO proy_dto = new ProyeccionesDTO();
            proy_dto.idsala = Int32.Parse(idSala);
            proy_dto.idpelicula = Int32.Parse(idpelicula);
            proy_dto.fechas = Horario.Text;
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
        public void updateproy()
        {
            String idpelicula = "" + peliculaCb.SelectedValue;
            String idSala = "" + salasCB.SelectedValue;

            ProyeccionesDTO proy_dto = new ProyeccionesDTO();
            proy_dto.idsala = Int32.Parse(idSala);
            proy_dto.idpelicula = Int32.Parse(idpelicula);
            proy_dto.fechas = Horario.Text;
            proy_dto.idproyeccion = id;
            try
            {
                ProyeccionesDAO proy_dao = new ProyeccionesDAO();
                proy_dao.updateProyeccion(proy_dto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }
        
        private void acceptbtn_Click(object sender, EventArgs e)
        {
            if (isInsertId)
            {
                newproyecciones();
                this.Dispose();
            }
            else
            {
                //actualizar
                updateproy();
                this.Dispose();
            }
            
        }

       
        //Método LoadProyecciones
        public void LoadupdateProyecciones()
        {
            
            try
            {
                ProyeccionesDAO proy_dao = new ProyeccionesDAO();
                ProyeccionesDTO proy_dto = proy_dao.LoadProyecciones(id);
                Horario.Value = proy_dto.fechasDT;
                peliculaCb.SelectedValue = Convert.ToString(proy_dto.idpelicula);
                ProyeccionesDTO proy_dto_comp = proy_dao.LoadComplejoBySalas(proy_dto.idsala);
                complejosCb.SelectedValue = Convert.ToString(proy_dto_comp.idcomplejo);
                salasCB.SelectedValue = Convert.ToString(proy_dto.idsala);
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            

        }
        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void ComboChange(object Source, EventArgs args)
        {
            consultaSalas();
        }

        private void complejosCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
              
        }
    }

