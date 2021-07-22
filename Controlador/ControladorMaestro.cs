using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;

namespace Controlador
{
   public class ControladorMaestro
    {
        public static DataTable ObtenerMaterias()
        {
            return ModelMaestro.CargarMaterias();
        }

        //ATRIBUTOS
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public int idMateria { get; set; }

        //CONSTRUCTOR
        public  ControladorMaestro(string pnombres, string papellidos, int pidMateria)
        {
            //Atributo = parametro
            nombres = pnombres;
            apellidos = papellidos;
            idMateria = pidMateria;
        }

        #region INNERJOIN
        //inner join
        public static DataTable CargarMateriaInner(int idMate)
        {
            return ModelMaestro.cargarMateriaInner(idMate);
        }

        #endregion


        //CRUD
        public bool EnviarDatosController()
        {
            return ModelMaestro.RegistrarDocente(nombres, apellidos, idMateria);
        }

        public static DataTable CargarDocentes_Controller()
        {
            return ModelMaestro.ObtenerListaDocentes();
        }

        public static DataTable ObtenerListaDocentes()
        {
            throw new NotImplementedException();
        }
    }
}
