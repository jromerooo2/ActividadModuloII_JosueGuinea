using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class ModeloIngresoNotas
    {
        public static bool IngresarNota(int idAlumno, int idMateria, int idPeriodo, int Nota)
        {
            bool retorno = false;
            try
            {
                //PROCESO DE INSERCIÓN.
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tbnotas(idAlumno, idMateria,idPeriodo, Nota) VALUES('{0}','{1}','{2}', '{3}')", idAlumno, idMateria, idPeriodo, Nota), ModeloConexion.ObtenerConexion());
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

