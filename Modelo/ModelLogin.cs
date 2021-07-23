using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class ModelLogin
    {
        public static bool Acceso(string usuario, string passwordUsuario, int rolUsuario)
        {
            bool retorno = false;
            try
            {
                string query = "SELECT * FROM tbusuarios WHERE usuario = BINARY ?param1 AND passwordUsuario = BINARY ?param2 AND rolUsuario = BINARY ?param3";
               MySqlCommand cmdselect = new MySqlCommand(string.Format(query),ModeloConexion.ObtenerConexion());
                cmdselect.Parameters.Add(new MySqlParameter("param1", usuario));
                cmdselect.Parameters.Add(new MySqlParameter("param2", passwordUsuario));
                cmdselect.Parameters.Add(new MySqlParameter("param3", rolUsuario));
                retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());
                return retorno;
            }
            catch (Exception)
            {

                return retorno;
            }
        }
    }
}
