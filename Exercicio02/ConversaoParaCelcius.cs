using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    internal class ConversaoParaCelcius
    {
        private double temperatura;

        public ConversaoParaCelcius(double temperatura)
        {
            this.temperatura = temperatura;
        }

        public double FahrenheitParaCelsius()
        {
            return (temperatura - 32) * 5 / 9;
        }

        public double CelsiusParaFahrenheit()
        {
            return (temperatura * 9 / 5) + 32;
        }
    }
}
