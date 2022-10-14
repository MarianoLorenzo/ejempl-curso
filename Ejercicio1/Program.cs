using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Telefono t1 = new Telefono("s41", "sony");
            //t1.NumeroTelefonico = "4554-4466";
            //t1.CodigoOperador = 3;

            Edificio e1 = new Edificio("1 A", "Lopez Obrador");
            e1.Expensas = 10000;

            Console.WriteLine(e1.calcular(e1.Departamento));
            Console.WriteLine("La expensa es de: $" + e1.Expensas.ToString("0,000.00"));
            //Console.WriteLine(t1.llamar("Pedro"));
            Console.ReadKey();

        }
    }
}
