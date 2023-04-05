using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08
{
    internal class CalcularVolumeDaLata
    {    
            private double raio, altura;

            public CalcularVolumeDaLata(double raio, double altura)
            {
                this.raio = raio;
                this.altura = altura;
            }

            //Método
            public double CalcularVolume()
            {
                return Math.PI * Math.Pow(this.raio, 2) * this.altura;
            }
    }
}

