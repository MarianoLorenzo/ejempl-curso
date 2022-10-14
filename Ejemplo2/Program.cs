using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Articulo[] articulos = new Articulo[10];
            
            for (int x = 0; x < 10; x++)
            {
                articulos[x] = new Articulo();
                Console.WriteLine("Ingrese el artículo:");
                Console.WriteLine("Código:");
                articulos[x].CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Precio:");
                articulos[x].Precio = float.Parse(Console.ReadLine());
                Console.WriteLine("Marca:");
                articulos[x].CodigoMarca = int.Parse(Console.ReadLine());
            }

            Ventas v1 = new Ventas();
            Console.WriteLine("Ingrese la venta: ");
            Console.WriteLine("Código de cliente: ");
            v1.CodigoCliente = int.Parse(Console.ReadLine());

            while (v1.CodigoCliente != 0)
            {
                Console.WriteLine("Código de artículo: ");
                v1.CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad: ");
                v1.Cantidad = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la venta: ");
                Console.WriteLine("Código de cliente: ");
                v1.CodigoCliente = int.Parse(Console.ReadLine());
            }


        }
    }
}
