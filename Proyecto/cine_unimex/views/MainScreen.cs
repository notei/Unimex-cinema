﻿using System;
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

        private void tipoProyeccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoProyeccionForm frmTproyeccion = new TipoProyeccionForm();
            frmTproyeccion.MdiParent = this;
            frmTproyeccion.StartPosition = FormStartPosition.CenterScreen;
            frmTproyeccion.Show();

        }

        private void actoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Actores frmActores = new Actores();
            frmActores.MdiParent = this;
            frmActores.StartPosition = FormStartPosition.CenterScreen;
            frmActores.Show();
        }

        private void películasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Peliculas frmPeli = new Peliculas();
            frmPeli.MdiParent = this;
            frmPeli.StartPosition = FormStartPosition.CenterScreen;
            frmPeli.Show();
        }

        private void salasToolStripMenuItem_Click(object sender, EventArgs e)
        {


            SalasForm frmSalas = new SalasForm();
            frmSalas.MdiParent = this;
            frmSalas.StartPosition = FormStartPosition.CenterParent;
            frmSalas.Show();


        }

        private void cortosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CortosForm frmCortos = new CortosForm();
            frmCortos.MdiParent = this;
            frmCortos.StartPosition = FormStartPosition.CenterParent;
            frmCortos.Show();


        }

        private void estrenosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            peliculas_estrenos formestrenos = new peliculas_estrenos();
            formestrenos.MdiParent = this;
            formestrenos.StartPosition = FormStartPosition.CenterParent;
            formestrenos.Show();
        }

        
    }
}
