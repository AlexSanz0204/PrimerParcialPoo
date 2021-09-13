using ParcialPoo.Entidades;
using ParcialPoo.Ngocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = Console.ReadLine();
            int contra = Convert.ToInt32(Console.ReadLine());

            Usuario Cons = new Usuario(nombre, contra);
            ClsUsuario clsUsuario = new ClsUsuario();

            Console.WriteLine("Ingrese su nombre de usuario");
            Cons.Nombre = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Ingrese su Contraseña");
            Cons.Contra = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(clsUsuario.Acceso(Cons));

            Ventas ventas = new Ventas();

            Console.ReadKey();
        }
    }
}
