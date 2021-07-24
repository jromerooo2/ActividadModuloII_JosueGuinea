using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public class ControladorIngresoNotas
    {
        //ATRIBUTOS
        public string nombres { get; set; }
        public string apellidos { get; set; }       
        public int nota { get; set; }
       

        //CONSTRUCTOR
        public ControladorIngresoNotas(string pnombres, string papellidos,  int pnota )
        {
            //Atributo = parametro
            nombres = pnombres;
            apellidos = papellidos;
            nota = pnota;

        }
        public bool EnviarDatosController()
        {
            return ModeloIngresoNotas.IngresarNota(nombres, apellidos, nota);
        }
    }

   
}
