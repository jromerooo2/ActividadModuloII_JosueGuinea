using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modelo
{
    public class ModelEstudiante
    {
        //Cargar la especialidad de la base de datos
        public static DataTable CargarEspecialidad()
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tbespecialidad";
                MySqlCommand cmdEspecialidad = new MySqlCommand(string.Format(instruccion), ModeloConexion.ObtenerConexion());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdEspecialidad);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }
        public static DataTable CargarGrado()
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tbgrados";
                MySqlCommand cmdGrados = new MySqlCommand(string.Format(instruccion), ModeloConexion.ObtenerConexion());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdGrados);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }
        public static class ModelTeacher
        {
                        
        }
    }
}
