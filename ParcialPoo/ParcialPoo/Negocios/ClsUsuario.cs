using ParcialPoo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialPoo.Ngocios
{
    class ClsUsuario
    {
        string user = "Juanito";
        Double clave = 2021;
        int y = 1;

        Usuario Cons = new Usuario();


        public string Acceso(Usuario Cons)
        {
            if (Cons.Nombre == user && Cons.Contra == clave)

            {
                y = 1;
                return "inicio de sesión Correcto, bienvenido.";
            }
            else
                y = 2;
            return "Sus credenciales de usuario o contraseña son incorrectas, vuelva a intentarlo.";
        }
    }
}
