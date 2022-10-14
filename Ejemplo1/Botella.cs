using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    class Botella
    {
        public Botella (string color, string material)
        {
            this.color = color;
            this.material = material;
            capacidad = 100;
            cantidadActual = 0;
        }

        public Botella () { }

        private int capacidad;
        private string color;
        private string material;
        private int cantidadActual;

        //public int Capacidad
        //{
        // get { return capacidad; }
        //  set { capacidad = value; }
        //  }
        public int Capacidad
        {
            get { return capacidad; }
        }

        public int CantidadActual
        {
            get { return cantidadActual; }
        }

        public string Material
        {
            get { return material; }
        }

        public float recargar ()
        {
            if (cantidadActual > 0)
            {
                int dif = capacidad - cantidadActual;
                float monto = dif / 100 * 50;
                cantidadActual =+ dif;
                return monto;
            }
            cantidadActual = 100;
            return 50;
        }

        public float recargar (int cantidad)
        {
            cantidadActual += cantidad;
            return cantidad / 100 * 50;
        }
    }

}
