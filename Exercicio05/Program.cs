// Crie um programa para calcular o volume de uma esfera 
using Exercicio05;
using System;
using System.Collections.Generic;
namespace ExVolumeEsfera
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o raio da esfera: ");
            double raio = double.Parse(Console.ReadLine());

            //Instância da classe Esfera + chamar método CalcularVolume calcular o volume 
            CalcularVolumeEsfera esfera = new CalcularVolumeEsfera(raio);
            double volume = esfera.CalcularVolume();

            //Exibe o resultado
            Console.WriteLine($"Volume da esfera: {volume:F2}");
        }
    }
}
