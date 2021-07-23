using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Modelo;

namespace Controlador
{
    public class ControladorLogin : AtributosLogin
    {
        public static bool Acceso_Controller()
        {
            return ModelLogin.Acceso(usuario,passwordUsuario);
        }
        public static int GetUserRol()
        {
            rolUsuario = ModelLogin.GetRol(usuario, passwordUsuario);

            return ModelLogin.GetRol(usuario, passwordUsuario);
        }
    }
    public class AtributosLogin
    {
        public static string usuario { get; set; }
        public static string passwordUsuario { get; set; }
        public static int rolUsuario { get; set; }
        public AtributosLogin() { }

    }
}
