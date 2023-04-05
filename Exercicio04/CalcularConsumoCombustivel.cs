using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    internal class CalcularConsumoCombustivel
    {
        private double kmInicial, kmFinal, consumoCombustivel;

        //Construtor da classe Veiculo --> recebe e armazena as variáveis
        public CalcularConsumoCombustivel(double kmInicial, double kmFinal, double consumoCombustivel)
        {
            this.kmInicial = kmInicial;
            this.kmFinal = kmFinal;
            this.consumoCombustivel = consumoCombustivel;
        }
        //Método público CalcularConsumo --> para calcular o consumo de combustível por km e retornar resultado.
        public double CalcularConsumo()
        {
            double kmPercorridos = kmFinal - kmInicial;
            double consumo = kmPercorridos / consumoCombustivel;
            return consumo;
        }
    }
}
