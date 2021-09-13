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
        public string comprobante;

        string usuario = "Juanito";
        int contraseña = 2021;
        public string Acceso(string nombre, int contra)
        {
            if (nombre == usuario && contra == contraseña)

            {
                comprobante = "1";
                return "inicio de sesión Correcto, bienvenido.";
            }
            else
            return "Sus credenciales de usuario o contraseña son incorrectas, vuelva a intentarlo.";
        }
    }
}