using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using unimex.lenguajesv.cine.DTO;

namespace unimex.lenguajesv.cine.views
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UsuarioDTO usuario = (UsuarioDTO)Sesion.getElement("USUARIO");
            this.Text += " - " + usuario.NombreUsuario;
        }

        private void MainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            cerrarAplicacion();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarAplicacion();
        }

        private void cerrarAplicacion()
        {
            Application.Exit();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDeScreen screen = new AcercaDeScreen();
            screen.MdiParent = this;
            screen.StartPosition = FormStartPosition.CenterScreen;
            screen.Show();
        }

        private void proyeccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProyeccionesForm frmProy = new ProyeccionesForm();
            frmProy.MdiParent = this;
            frmProy.StartPosition = FormStartPosition.CenterScreen;
            frmProy.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuariosForm frmUsuarios = new UsuariosForm();
            frmUsuarios.MdiParent = this;
            frmUsuarios.StartPosition = FormStartPosition.CenterScreen;
            frmUsuarios.Show();
        }

        private void preciosDeBoletosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreciosForm frmPrecios = new PreciosForm();
            frmPrecios.MdiParent = this;
            frmPrecios.StartPosition = FormStartPosition.CenterScreen;
            frmPrecios.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProveedoresForm frmProveedores = new ProveedoresForm ();
            frmProveedores.MdiParent = this;
            frmProveedores.StartPosition = FormStartPosition.CenterScreen;
            frmProveedores.Show();
        }

        private void nacionalidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NacionalidadesForm frmNacional = new NacionalidadesForm();
            frmNacional.MdiParent = this;
            frmNacional.StartPosition = FormStartPosition.CenterScreen;
            frmNacional.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductosForm frmProductos = new ProductosForm();
            frmProductos.MdiParent = this;
            frmProductos.StartPosition = FormStartPosition.CenterScreen;
            frmProductos.Show();
        }

        
    }
}
