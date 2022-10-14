using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    class Persona
    {
        private int edad;
        private float sueldo;
        private string nombre;

        public Persona (string nombre)
        {
            this.nombre = nombre;
        }

        public void setEdad(int e)
        {
            edad = e;
        }

        public int getEdad()
        {
            return edad;
        }

        public string saludar()
        {
            return "Hola soy " + nombre;
        }

        public string saludar(string nombre)
        {
            return "Hola " + nombre + " soy" + this.nombre;
        }

            
    }

}
