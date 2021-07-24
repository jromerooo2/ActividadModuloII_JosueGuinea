using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public  class ModeloIngresoNotas
    {
        public static bool IngresarNota(string nombre, string apellido, int nota)
        {
            bool retorno = false;
            try
            {
                //PROCESO DE INSERCIÓN.
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tbnota(nombreAlumno, apellidoAlumno,Nota) VALUES('{0}','{1}','{2}')", pnommbres, papellidos, pnota), ModeloConexion.ObtenerConexion());
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
    }
}
