//  Crie um programa para converter a temperatura de graus Fahrenheit para  graus Celsius 
using System;

//classe Temperatura que armazena a temperatura em graus Fahrenheit
class Temperatura
{
    private double temperatura;

    public Temperatura(double temperatura)
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

class Program
{
    //Ler a temperatura em Fahrenheit e criar uma instância da classe Temperatura 
    static void Main(string[] args)
    {
        Console.Write("Digite a temperatura em graus Fahrenheit: ");
        double temperaturaFahrenheit = double.Parse(Console.ReadLine());

        Temperatura temperatura = new Temperatura(temperaturaFahrenheit);
        double temperaturaCelsius = temperatura.FahrenheitParaCelsius();

        Console.WriteLine($"Temperatura em graus Celsius: {temperaturaCelsius:F2}");
    }
}
