using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06
{
    internal class ConversaoCelciusFahrenheit
    {
        //Criando método CelsiusParaFahrenheit --> recebe argumento temperaturaCelsius
        public double CelsiusParaFahrenheit(double temperaturaCelsius)
        {
            double temperaturaFahrenheit = (temperaturaCelsius * 9 / 5) + 32;
            return temperaturaFahrenheit;
        }
    }
}
