using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modelo;

namespace Controlador
{
    public class ControladorEstudiante
    {

        //ATRIBUTOS
        public static int idEstudiante { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string direccion { get; set; }
        public int idEspecialidad { get; set; }
        public int idGrado { get; set; }
        public int idGeneros { get; set; }

        //CONSTRUCTOR
        public ControladorEstudiante(string pnombres, string papellidos, string pdireccion,int pidGrado, int pidEspecialidad, int pidGeneros)
        {
            //Atributo = parametro
            nombres = pnombres;
            apellidos = papellidos;
            direccion = pdireccion;
            idEspecialidad = pidEspecialidad;
            idGrado = pidGrado;
            idGeneros = pidGeneros;

        }

        //Controlador sobre el combobox de especialidad.
        public static DataTable ObtenerEspecialidad()
        {
            return ModelEstudiante.CargarEspecialidad();
        }

        public static DataTable ObtenerGrado()
        {
            return ModelEstudiante.CargarGrado();
        }

        public static DataTable ObtenerGenero()
        {
            return ModelEstudiante.CargarGenero();
        }

        //CRUD
        public bool EnviarDatosController()
        {
            return ModelEstudiante.RegistrarEstudiante(nombres, apellidos, direccion, idGrado, idGeneros, idEspecialidad);
        }
        public static DataTable CargarAlumnos_Controller()
        {
            return ModelEstudiante.ObtenerListaAlumnos();
        }

        public static DataTable CargarAlumnos_Controller2()
        {
            return ModelEstudiante.ObtenerListaAlumnos2();
        }

        public static bool EliminarEstudiante(int id)
        {
            return ModelEstudiante.EliminarEstudiante(id);
        }

        public static bool ActualizarEstudiante_Controller(int id)
        {
            return ModelEstudiante.ActualizarEstudiante(id, nombres, apellidos, direccion, idGrado, idGeneros, idEspecialidad);
        }
    }
}
