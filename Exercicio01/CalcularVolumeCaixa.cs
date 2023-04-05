using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class CalcularVolumeCaixa
    {
        private double comprimento, largura, altura;
         
        public CalcularVolumeCaixa(double comprimento, double largura, double altura)
        {
            this.comprimento = comprimento;
            this.largura = largura;
            this.altura = altura;
        }

        //Método CalculandoOVolume() que calcula e retorna o volume da caixa
        public double CalculandoOVolume()
        {
            double volumeDaCaixa = altura * largura * comprimento;
            return volumeDaCaixa;
        }
    }
}
