// Crie um programa para calcular o volume de uma lata de óleo
using Exercicio08;
using System;
using System.Collections.Generic;
namespace ExVolumeLataOleo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cores do console são alteradas para amarelo com Console.ForegroundColor = ConsoleColor.Yellow.
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("**************************************");
            Console.WriteLine("**** CÁLCULO DO VOLUME DA LATA ******");
            Console.WriteLine("**************************************\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Digite o raio da lata em cm: ");
            double raio = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura da lata em cm: ");
            double altura = double.Parse(Console.ReadLine());

            //Instância da classe VolumeLataOleo
            CalcularVolumeDaLata lata = new CalcularVolumeDaLata(raio, altura);
            double volume = lata.CalcularVolume();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nO volume da lata é de: {0:0.00} cm³", volume);

            Console.ResetColor();
        }
    }
}




