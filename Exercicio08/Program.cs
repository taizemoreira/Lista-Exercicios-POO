// Crie um programa para calcular o volume de uma lata de óleo
using System;

class VolumeLataOleo
{
    private double raio, altura;

    public VolumeLataOleo(double raio, double altura)
    {
        this.raio = raio;
        this.altura = altura;
    }

    //Método
    public double CalcularVolume()
    {
        return Math.PI * Math.Pow(this.raio, 2) * this.altura;
    }
}

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
        VolumeLataOleo lata = new VolumeLataOleo(raio, altura);
        double volume = lata.CalcularVolume();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nO volume da lata é de: {0:0.00} cm³", volume);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n**************************************");
        Console.WriteLine("********* OBRIGADO POR USAR! *********");
        Console.WriteLine("**************************************");

        Console.ResetColor();
    }
}




