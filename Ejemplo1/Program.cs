using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
           // Persona p1 = new Persona("Pepe");
           // p1.setEdad(20);
           // Console.WriteLine(p1.saludar());
           // Console.WriteLine(p1.saludar("Maxi"));


            Botella b1 = new Botella("Rojo", "Plástico");
            //b1.Capacidad = 200;
           // int algo = b1.Capacidad;

            //Perro pe1 = new Perro();
           // pe1.Nombre = "Roma";

           // Console.WriteLine(p1.saludar());
            Console.WriteLine("La capaciad de la botella es: " + b1.Capacidad);
            Console.WriteLine("La cantidad actual de la botella es: " + b1.CantidadActual);

            b1.recargar(20);
            Console.WriteLine("Luego de recargar, La cantidad de la botella es: " + b1.CantidadActual);

            b1.recargar();
            Console.WriteLine("Luego de recargar, La cantidad de la botella es: " + b1.CantidadActual);
            Console.ReadKey();


        }
    }
}
