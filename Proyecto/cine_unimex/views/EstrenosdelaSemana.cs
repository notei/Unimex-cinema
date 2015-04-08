using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace unimex.lenguajesv.cine.views
{
    public partial class EstrenosdelaSemana : Form
    {
        public EstrenosdelaSemana()
        {
            InitializeComponent();
        }

        private void EstrenosdelaSemana_Load(object sender, EventArgs e)
        {
            EstrenosdelaSemana();
            dgvLoad.DefaultCellStyle.BackColor = Color.LightGray;
            dgvLoad.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;

        }
        private String SQL_Consulta_Proyecciones = "select pelicula, fecha_estreno from peliculas,  peliculas_estrenos";
        private String Cadena = Properties.Resources.CADENA_CONEXION;
        //private String Cadena = "Data Source=LOCALHOST;Initial Catalog=unimex_cinema_db;Integrated Security=true";
        public DataTable LoadEstrenosDeLaSemana()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_Consulta_Proyecciones, con))
            {

                DataTable tbl = new DataTable();
                adapter.Fill(tbl);
                con.Close();
                return tbl;
            }
        }
        public void EstrenosdelaSemana()
        {
            try
            {
                DataTable pc = LoadEstrenosDeLaSemana();
                dgvLoad.DataSource = pc;
            }
            //Se controla la excepcion,  y muestra una ventana con la causa de la excepcion  
            catch (Exception exe)
            {
                MessageBox.Show("" + exe);
            }
        }
    }
}
