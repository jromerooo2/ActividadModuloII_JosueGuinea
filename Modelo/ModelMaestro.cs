﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modelo
{
     public class ModelMaestro
    {
        //LoadMateria
        public static DataTable CargarMaterias()
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tbmaterias";
                MySqlCommand cmdtipodoc = new MySqlCommand(string.Format(instruccion), ModeloConexion.ObtenerConexion());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdtipodoc);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }

        //CRUD
        public static bool RegistrarDocente(string pnombres, string papellidos, int pidmateria)
        {
            bool retorno = false;
            try
            {
                //PROCESO DE INSERCIÓN
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tbmaestros(nombreMaestro,apellidoMaestro,idMateria) VALUES({0},{1},{2})", pnombres, papellidos, pidmateria)
                    , ModeloConexion.ObtenerConexion());
                //VERIFICACIÓN DE INSERCIÓN
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                //RETORNO
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }
    }
}