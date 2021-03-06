﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using unimex.lenguajesv.cine.DTO;

namespace unimex.lenguajesv.cine.DAO
{
    class PreciosDAO
    {

        private String SQL_Consulta_Precios = "select cat_precios.id_precio AS Id , cat_precios.nombre AS Boleto, cat_precios.descripcion AS Descripción, cat_precios.precio AS Precio FROM cat_precios";
        private String Cadena = Properties.Resources.CADENA_CONEXION;

        public DataTable loadPrecios ()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_Consulta_Precios, con))
            {

                DataTable tblp = new DataTable();
                adapter.Fill(tblp);
                con.Close();
                return tblp;
            }
           
        }
        public void agregarPrecio(PreciosDTO pdto)
        {
            String SQL_Agregar_Precio = " insert into cat_precios (nombre, descripcion, precio) values ( '" + pdto.Nombre + "' , '" + pdto.Descripcion + "', " + pdto.Precios + ")";
            SqlConnection con;
            con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand comando;
            comando = new SqlCommand(SQL_Agregar_Precio, con);
            comando.ExecuteNonQuery();
            con.Close();
        }
        public PreciosDTO cargarPreciosUpdate (int id)
        {
            String SQL_Cargar_Precios = "select * from cat_precios where id_precio = "+ id;
            PreciosDTO prdto = new PreciosDTO();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL_Cargar_Precios, con);
            SqlDataReader red = cmd.ExecuteReader();
            while (red.Read())
            {
                prdto.id_Precios = (int)red.GetInt32(0);
                prdto.Nombre = (String)red.GetString(1);
                prdto.Descripcion = (String)red.GetString(2);
                prdto.Precios = (Single)red.GetDouble(3);
            }
            con.Close();
            return prdto;
        }
        public void updatePreciosDTO (PreciosDTO preciodtoup)
        {
            String SQL_Update_Precio = " UPDATE cat_precios SET nombre = '"+preciodtoup.Nombre+"', descripcion = '"+preciodtoup.Descripcion+"', precio = "+preciodtoup.Precios+" WHERE id_precio = "+preciodtoup.id_Precios;
            SqlConnection con;
            con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand comando;
            comando = new SqlCommand(SQL_Update_Precio, con);
            comando.ExecuteNonQuery();
            con.Close();
        }
        public void deletePrecioDTO (PreciosDTO deletedto)
        {
            String SQL_Update_Precio = " DELETE FROM cat_precios WHERE id_precio = "+deletedto.id_Precios;
            SqlConnection con;
            con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand comando;
            comando = new SqlCommand(SQL_Update_Precio, con);
            comando.ExecuteNonQuery();
            con.Close();
        }

        public DataTable cargaBusquedaPrecio (PreciosDTO busdtopre)
        {
            String SQL_Buscar_Precio = "select cat_precios.id_precio AS Id , cat_precios.nombre AS Boleto, cat_precios.descripcion AS Descripción, cat_precios.precio AS Precio from cat_precios where cat_precios.id_precio = " + busdtopre.id_Precios;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            using (SqlDataAdapter adapter1 = new SqlDataAdapter(SQL_Buscar_Precio, con))
            {

                DataTable tblpbus = new DataTable();
                adapter1.Fill(tblpbus);
                con.Close();
                return tblpbus;
            }
        }
        public DataTable LoadNombrePrecio ()
        {
            String SQL_Busc_Precio = "select id_precio, nombre from cat_precios";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_Busc_Precio, con))
            {

                DataTable tbl = new DataTable();
                adapter.Fill(tbl);
                con.Close();
                return tbl;
            }
        }
        public DataTable LoadPrecPrecio()
        {
            String SQL_Busc_Precio = "select id_precio, precio from cat_precios";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Cadena;
            con.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(SQL_Busc_Precio, con))
            {

                DataTable tbl = new DataTable();
                adapter.Fill(tbl);
                con.Close();
                return tbl;
            }
        }
    }
}
