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
        public int idAlumno { get; set; }
        public int idMateria { get; set; }
        public int idPeriodo { get; set; }
        public int Nota { get; set; }


        //CONSTRUCTOR
        public ControladorIngresoNotas(int pIdalumno, int pIdmateria, int pIdperiodo, int pNota)
        {
            //Atributo = parametro
            idAlumno = pIdalumno;
            idMateria = pIdmateria;
            idPeriodo = pIdperiodo;
            Nota = pNota;

        }
        public bool EnviarDatosController()
        {
            return ModeloIngresoNotas.IngresarNota(idAlumno, idMateria, idPeriodo, Nota);
        }
    }


}
