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
    public partial class NewEstrenos : Form
    {

        private int id;
        Boolean idb = false;


        public NewEstrenos()
        {
               
            InitializeComponent();
            idb = true;
            btnAceptar.Text = "Agregar";
            lblEstrenos.Text = "Agregar Estreno";
            
        }

        public NewEstrenos (int id)
        {
            InitializeComponent();
            this.id = id;
            btnAceptar.Text = "Actualizar";
            lblEstrenos.Text = "Actualizar Estreno";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void NewEstrenos_Load(object sender, EventArgs e)
        {
             if (idb)
            {
               EstrenosDAO nacup = new EstrenosDAO();
                nacup.loadEstrenos();
            }
            else
            {
                cargarNewEstrenoUpdate();
            }
        
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
          String idpelicula = "" + cmbIdPeliculas.SelectedValue;
            if (idb)
            {
                if (cmbIdPeliculas.SelectedValue != "")
                {
                    EstrenosDTO n = new EstrenosDTO();
                   n.Id_pelicula = Int32.Parse(idpelicula);
                    n.Fecha_estreno = dtFecha.Text;
                    n.Habilitado = chkHabilitado.Checked;


                    try
                    {
                        EstrenosDAO dao = new EstrenosDAO();
                        dao.agregarEstrenos(n);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }

                }

                else
                {
                    MessageBox.Show(" Ingrese un estreno ", " ERROR");
                }
                this.Dispose();
            }
            else
            {
                //Program Act
               
              EstrenosDTO naup = new EstrenosDTO ();
                naup.Id_estrenos = id;
                naup.Id_pelicula = id;
                naup.Fecha_estreno = dtFecha.Text;
                naup.Habilitado = chkHabilitado.Checked;
                                    
                try
                {
                    EstrenosDAO newdao = new EstrenosDAO();
                    newdao.updateEstrenosDTO (naup);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
                this.Dispose();
            }
        }
        public void cargarNewEstrenoUpdate()
        {
            try
            {
                EstrenosDAO nadao = new EstrenosDAO ();
                EstrenosDTO nadto = nadao.cargarEstrenoUpdate(id);
                cmbIdPeliculas.SelectedValue = nadto.Id_pelicula;
                dtFecha.Text= nadto.Fecha_estreno;
                chkHabilitado.Checked = nadto.Habilitado;

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }
        }
    }

