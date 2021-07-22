using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modelo
{
    public class ModelUsuario
    {
        public static bool RegistrarUsuario(string pusuario, string ppassword, int prol)
        {
            bool retorno = false;
            //string passwordEncrypted = 
            try
            {
                //PROCESO DE INSERCIÓN
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tbusuarios(usuario, passwordUsuario, rolUsuario) VALUES('" + pusuario + "' , '" + ppassword + "', '" + prol + "'   )"), ModeloConexion.ObtenerConexion());
                //VERIFICACIÓN DE INSERCIÓN
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
