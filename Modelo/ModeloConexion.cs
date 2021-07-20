using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Modelo
{
    class ModeloConexion
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection retorno;
            string server, database, user, password, puerto;
            server = "sql10.freemysqlhosting.net";
            database = "sql10426558";
            user = "sql10426558";
            password = "MaJmEkn8n9";
            puerto = "3306";
            try
            {
                retorno = new MySqlConnection("server = " + server +
                                              "; database = " + database +
                                              "; uid = " + user +
                                              "; pwd = " + password +
                                              "; port = " + puerto);
                retorno.Open();
                return retorno;
            }
            catch (Exception)
            {
                return retorno = null;
            }
        }
    }
}
