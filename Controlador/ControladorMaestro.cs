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

        public static DataTable ObtenerPeriodo()
        {
            return ModelMaestro.CargarCmbPeriodo();
        }

        //ATRIBUTOS
        public static string nombres { get; set; }
        public static string apellidos { get; set; }
        public static int idMateria { get; set; }

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


        public static bool EliminarDocente(int id)
        {

            return ModelMaestro.DeleteMaestro(id);
        }

        public static bool UpdateMaestro(int id)
        {
            return ModelMaestro.UpdateMaestro(id, nombres, apellidos, idMateria);
        }

        //RETORNO PARA CARGAR CMBPERIODO
        public static DataTable CargarPeriodos()
        {
            return ModelMaestro.CargarCmbPeriodo();
        }
    }
}
