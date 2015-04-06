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
    public partial class NewUsuarios : Form
    {
        private int id;
        Boolean isInsertId = false;
        public NewUsuarios()
        {
            InitializeComponent();
            isInsertId = true;
            btnAceptar.Text = "Agregar";
        }

        public NewUsuarios(int id)
        {
            InitializeComponent();
            this.id = id;
            isInsertId = false;
            btnAceptar.Text = "Actualizar";
        }

        public void cargarNewUsuariosUpdate()
        {
            try
            {
                UsuariosDAO presdao = new UsuariosDAO();
                UsuariosDTO presdto = presdao.cargarUsuariosUpdate(id);
                nombreuser.Text = presdto.Nombre;
                apuser.Text = presdto.ApPaterno;
                nomus.Text = presdto.NomUsuario;
                passuser.Text = presdto.Contrasena;

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }
        private void NewUsuarios_Load(object sender, EventArgs e)
        {

            if (isInsertId)
            {
                UsuariosDAO predaao = new UsuariosDAO();
                predaao.LoadUsuarios();
            }
            else
            {
                //cargarNewUsuariosUpdate();
            }
        }

       

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            if (isInsertId)
            {
                if (nombreuser.Text != "")
                {
                    UsuariosDTO n = new UsuariosDTO();
                    n.Nombre = nombreuser.Text;
                    n.ApPaterno = apuser.Text;
                    n.NomUsuario = nomus.Text;
                    n.Contrasena = passuser.Text;
                    n.Id_Tipo_Usuario = Int32.Parse(idtuser.Text);




                    try
                    {
                        UsuariosDAO dao = new UsuariosDAO();
                        dao.agregarUsuario(n);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }

                }

                else
                {
                    MessageBox.Show(" Verificar Valores ", " ERROR");
                }
                this.Dispose();
            }
            else
            {
                //Prgramar Actualizar
                UsuariosDTO pdtoup = new UsuariosDTO();
                pdtoup.idusuario = id;
                pdtoup.Nombre = nombreuser.Text;
                pdtoup.ApPaterno = apuser.Text;
                pdtoup.NomUsuario = nomus.Text;
                pdtoup.Contrasena = passuser.Text;
                pdtoup.Id_Tipo_Usuario = Int32.Parse(idtuser.Text);
                try
                {
                    UsuariosDAO daoprecio1 = new UsuariosDAO();
                    daoprecio1.updateUsuariosDTO(pdtoup);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
                this.Dispose();
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }


        /*  public void cargarNewUsuariosUpdate()
          {
              try
              {
                  UsuariosDAO presdao = new UsuariosDAO();
                  UsuariosDTO presdto = presdao.cargarUsuariosUpdate(id);
                  nombreuser.Text = presdto.Nombre;
                  apuser.Text = presdto.ApPaterno;
                  nomus.Text = presdto.NomUsuario;
                  passuser.Text = presdto.Contrasena;
                  idtuser.Text = Convert.ToString(presdto.Id_Tipo_Usuario);


              }
              catch (Exception ex)
              {
                  MessageBox.Show("" + ex);
              }

          }
          private void NewUsuarios_Load(object sender, EventArgs e)
          {
              if (isInsertId)
              {
                  UsuariosDAO predaao = new UsuariosDAO();
                  predaao.LoadUsuarios();
              }
              else
              {
                  //cargarNewUsuariosUpdate();
              }
          }*/
    }
}
