using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    internal class CalcularVolumeEsfera
    {
        //use private para a variavel raio
        private double raio;

        //construtor da classe Esfera, recebemos o raio  e armazena
        public CalcularVolumeEsfera(double raio)
        {
            this.raio = raio;
        }

        //Método público CalcularVolume
        public double CalcularVolume()
        {
            double volume = 4.0 / 3.0 * Math.PI * Math.Pow(raio, 3.0);
            return volume;
        }
    }
}
