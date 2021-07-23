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
        //CRUD
        public static bool RegistrarEstudiante(string pnommbres, string papellidos, string direccion, int pidEspecialidad, int pidGrado, int pidGenero)
        {
            bool retorno = false;
            try
            {
                //PROCESO DE INSERCIÓN.
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tbalumnos(nombreAlumno, apellidoAlumno,direccion, idSeccion, idEstado,idEspecialidad) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", pnommbres, papellidos, direccion, pidGrado, pidGenero, pidEspecialidad), ModeloConexion.ObtenerConexion());
                //VERIFICACIÓN DE INSERCIÓN.
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                //RETORNO
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }

        public static DataTable ObtenerListaAlumnos()
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tbalumnos";
                MySqlCommand cmdalumnos = new MySqlCommand(string.Format(instruccion), ModeloConexion.ObtenerConexion());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdalumnos);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }


        public static DataTable ObtenerListaAlumnos2()
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT nombreAlumno, apellidoAlumno, Nota FROM tbalumnos";
                MySqlCommand cmdalumnos = new MySqlCommand(string.Format(instruccion), ModeloConexion.ObtenerConexion());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdalumnos);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }


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
        public static DataTable CargarGenero()
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tbgeneros";
                MySqlCommand cmdGenero = new MySqlCommand(string.Format(instruccion), ModeloConexion.ObtenerConexion());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdGenero);
                data = new DataTable();
                adp.Fill(data);

                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }

    }
}
