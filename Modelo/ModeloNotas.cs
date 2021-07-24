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

        public static DataTable getGradesByID(int idAlumno)
        {
            DataTable data;
            try
            {
                string query = "SELECT idMateria,idPeriodo,nota FROM tbnotas WHERE idAlumno="+idAlumno;
                MySqlCommand cmdtipodoc = new MySqlCommand(string.Format(query), ModeloConexion.ObtenerConexion());
                cmdtipodoc.Parameters.Add(new MySqlParameter("param1", idAlumno));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdtipodoc);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }

        }
    }
}

