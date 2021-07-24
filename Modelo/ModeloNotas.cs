using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modelo
{
    public class ModeloNotas
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

        public static DataTable getGradesByID(int IdAlumno)
        {
            DataTable retorno ;
            try
            {
                //PROCESO DE INSERCIÓN.
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("SELECT idMateria, idPeriodo, nota FROM tbnotas WHERE  idALumno = " + IdAlumno), ModeloConexion.ObtenerConexion());
                //VERIFICACIÓN DE INSERCIÓN.
                cmdinsert.ExecuteNonQuery();
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdinsert);
                retorno = new DataTable();
                adp.Fill(retorno);
                return retorno;
            }
            catch (Exception)
            {
                return retorno = null;
            }
        }
    }
}

