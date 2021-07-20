using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
   public class ControladorMaestro
    {

        //ATRIBUTOS
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public int iddocente { get; set; }
        public int idMateria { get; set; }

        //CONSTRUCTOR
        public ControladorMaestro(string pnombres, string papellidos, int piddocente, int pidMateria)
        {
            //Atributo = parametro
            nombres = pnombres;
            apellidos = papellidos;
            iddocente = piddocente;
            idMateria = pidMateria;
        }

        //CRUD
        public bool EnviarDatosController()
        {
            return ModelMaestro.RegistrarMaestro(nombres, apellidos, iddocente, idMateria);
        }
    }
}
