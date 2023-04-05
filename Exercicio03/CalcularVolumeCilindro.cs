using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    internal class CalcularVolumeCilindro
    {
        private double raio, altura;

        //Construtor da classe Cilindro
        public CalcularVolumeCilindro(double raio, double altura)
        {
            this.raio = raio;
            this.altura = altura;
        }

        //A classe Cilindro possui um método público CalcularVolume
        public double CalcularVolume()
        {
            double volume = Math.PI * Math.Pow(raio, 2) * altura;
            return volume;
        }
    }
}
