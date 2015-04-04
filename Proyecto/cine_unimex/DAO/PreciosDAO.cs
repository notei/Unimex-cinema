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
        public PreciosDTO cargarPreciosconsulta (int id)
        {
            String SQL_Cargar_Precio = "select * from cat_precios where id_precio = " + id;
            PreciosDTO preciosdto = new PreciosDTO();
            SqlConnection con = new SqlConnection();            
            con.ConnectionString = Cadena;
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL_Cargar_Precio, con);
            SqlDataReader reaad = cmd.ExecuteReader();            
            while (reaad.Read())
            {
                preciosdto.id_Precios = (int)reaad.GetSqlInt32(0);
                preciosdto.Nombre = (String)reaad.GetString(1);
                preciosdto.Descripcion = (String)reaad.GetString(2);
                preciosdto.Precios = (float)reaad.GetFloat(3);
            }
            con.Close();
            return preciosdto;
            
        }
    }
}
