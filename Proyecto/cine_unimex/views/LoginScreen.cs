using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//Librerias internas que deben ser importadas
using unimex.lenguajesv.cine.DAO;
using unimex.lenguajesv.cine.DTO;

namespace unimex.lenguajesv.cine.views.views
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
           
        }


        //Boton de entrar de usuario (Login)
        private void entrarBtn_Click(object sender, EventArgs e)
        {
            String usuario = usuarioTxt.Text;
            String contrasena = contrasenaTxt.Text;

            //Verifica que los campos tengan datos
            if (usuario.Length == 0 || contrasena.Length == 0)
            {
                MessageBox.Show("Nombre de usuario y/o contraseña invalidos");
            }
            else 
            {
                //Busca el usuario en la base de datos
                UsuarioDAO dao = new UsuarioDAO();
                UsuarioDTO usuarioDto = dao.login(usuario, contrasena);

                //Si se encontró el usuario en la base de datos
                if (usuarioDto != null)
                {
                    Sesion.addElement("USUARIO", usuarioDto);
                    MessageBox.Show("Bienvenido " + usuarioDto.Nombre + " " + usuarioDto.ApellidPaterno);

                    //Despliega la nueva ventana de la aplicacion
                    MainScreen screen = new MainScreen();
                    screen.Show();

                    //Oculta la ventana actual
                    this.Hide();
                }
                else
                {
                    //Error con el usuario y la contraseña
                    MessageBox.Show("Nombre de usuario y/o contraseña incorrectos");
                }
            }
        }

        // Limpia los textos del formulario
        private void limpiarBtn_Click(object sender, EventArgs e)
        {
            usuarioTxt.Text     = "";
            contrasenaTxt.Text  = "";
        }
    }
}
