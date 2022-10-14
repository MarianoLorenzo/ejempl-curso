using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Edificio
    {
        private string departamento;
        private string propietario;
        private float expensas;

        public Edificio (string departamento, string propietario)
        {
            this.departamento = departamento;
            this.propietario = propietario;
        }
            
        public string Departamento
        {
            get { return departamento; }
        }

        public string Propietario
        {
            get { return propietario; }
        }

        public float Expensas
        {
            get { return expensas; }
            set { expensas = value; }
        }

        public string calcular (string departamento)
        {
            return "Calculando la expensa del " + departamento;
        }
    }
}
