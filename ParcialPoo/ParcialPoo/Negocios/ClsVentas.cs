using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParcialPoo.Entidades;

namespace ParcialPoo.Negocios
{
    class ClsVentas
    {
        public string Cobro(Ventas ventas)
        {

            Console.WriteLine("Estimado usuario, por favor ingrese el identificador del producto: ");
            ventas.Identificador_producto = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Estimado usuario, por favor ingrese el nombre del producto: ");
            ventas.Nombre_producto = Console.ReadLine();

            Console.WriteLine("Estimado usuario, por favor ingrese la descripción del producto: ");
            ventas.Nombre_producto = Console.ReadLine();

            Console.WriteLine("Estimado usuario, por favor ingrese el precio del producto: ");
            ventas.Precio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Estimado usuario, por favor ingrese la cantidad del producto: ");
            ventas.Cantidad = Convert.ToInt32(Console.ReadLine());
        }
    }
}
