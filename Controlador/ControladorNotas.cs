using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;

namespace Controlador
{
    public class ControladorIngresoNotas
    {
        //ATRIBUTOS
        public static int idAlumno { get; set; }
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
            return ModeloNotas.IngresarNota(idAlumno, idMateria, idPeriodo, Nota);
        }

        public static DataTable TraerNotasPorAlumno(int id)
        {
            return ModeloNotas.getGradesByID(id);
        }
    }


}
