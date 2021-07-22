using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public class ControladorUsuario
    {
        //CRUD 

        public static bool AgregarUsuario(string pass2encrypt, string usuario, int rol)
        {
            string encryptPass = Encrypt.GetMD5(pass2encrypt);

            return ModelUsuario.RegistrarUsuario(usuario, encryptPass, rol);
        }
    }
}
