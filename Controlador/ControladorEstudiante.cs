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
        public static DataTable ObtenerEspecialidad()
        {
            return ModelEstudiante.CargarEspecialidad();
        }
    }
}
