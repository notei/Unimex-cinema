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
           EstrenosForm formestrenos = new EstrenosForm();
            formestrenos.MdiParent = this;
            formestrenos.StartPosition = FormStartPosition.CenterParent;
            formestrenos.Show();
        }

        private void peoductos2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductosForm2 frmProy = new ProductosForm2();
            frmProy.MdiParent = this;
            frmProy.StartPosition = FormStartPosition.CenterScreen;
            frmProy.Show();

        }

        private void clientesFrecuentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesFrecuentesForm formCF = new ClientesFrecuentesForm();
            formCF.MdiParent = this;
            formCF.StartPosition = FormStartPosition.CenterScreen;
            formCF.Show();
        }

        private void tipoSonidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoSonidoForm formaTP = new TipoSonidoForm();
            formaTP.MdiParent = this;
            formaTP.StartPosition = FormStartPosition.CenterScreen;
            formaTP.Show();
        }

        private void películasYComplejoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportePyCDAOForm frmReporte = new ReportePyCDAOForm();
            frmReporte.MdiParent = this;
            frmReporte.StartPosition = FormStartPosition.CenterScreen;
            frmReporte.Show();
        }

        private void boletosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PuntodeVentaElegirComplejo formaPV = new PuntodeVentaElegirComplejo();         
            formaPV.MdiParent = this;
            formaPV.StartPosition = FormStartPosition.CenterScreen;
            formaPV.Show();
        }

        private void dulceríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PuntodeVentaDulceriaForm formaPVD = new PuntodeVentaDulceriaForm();
            formaPVD.MdiParent = this;
            formaPVD.StartPosition = FormStartPosition.CenterScreen;
            formaPVD.Show();
        }

        

        private void organizarVentanasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        
    }
}
