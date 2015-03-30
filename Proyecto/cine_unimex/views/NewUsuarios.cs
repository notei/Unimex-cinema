
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
        public NewUsuarios()
        {
            InitializeComponent();
        }

        private void NewUsuarios_Load(object sender, EventArgs e)
        {

        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
             if (nombreuser.Text != "")
            {
                UsuariosDTO n = new UsuariosDTO();
                n.idusuario = Int32.Parse(iduser.Text);//El id del usuario es identity no requiere ser ingresado verifica consulta 
                n.NomUsuario = nombreuser.Text;
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

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
        
    }
}
