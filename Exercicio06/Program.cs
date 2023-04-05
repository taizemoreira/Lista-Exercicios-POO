// Crie um programa para converter a temperatura da escala Celsius para a  escala Fahrenheit 
using Exercicio06;
using System;
using System.Collections.Generic;
namespace ExConversaoParaFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instância 
            ConversaoCelciusFahrenheit converter = new ConversaoCelciusFahrenheit();

            Console.WriteLine("Bem-vindo ao conversor de temperatura Celsius para Fahrenheit!\n");

            Console.Write("Digite uma temperatura em Celsius: ");
            double temperaturaCelsius = double.Parse(Console.ReadLine());

            double temperaturaFahrenheit = converter.CelsiusParaFahrenheit(temperaturaCelsius);

            Console.WriteLine("\n{0}°C é igual a {1}°F\n", temperaturaCelsius, temperaturaFahrenheit);

            Console.WriteLine("Obrigado por utilizar nosso conversor de temperatura!");
        }
    }
}
