//1) Utilizando Orientação a Objetos, crie um programa para calcular o volume de uma caixa retangular 
using Exercicio01;
using System;
using System.Collections.Generic;

namespace ExCaixaRetangular
{
    //Instância da classe CaixaRetangular
    class Program
    {
        static void Main(string[] args)
        {
            CalcularVolumeCaixa caixa = new CalcularVolumeCaixa(11.2, 22.2, 33.3);
            double volume = caixa.CalculandoOVolume();

            Console.WriteLine($"O Volume da caixa retangular é: {volume:F2}");
        }
    }
        
}






    