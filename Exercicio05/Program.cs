// Crie um programa para calcular o volume de uma esfera 
using System;

//Criando a classe esfera
    class Esfera
    {
    //use private para a variavel raio
        private double raio;

    //construtor da classe Esfera, recebemos o raio  e armazena
        public Esfera(double raio)
        {
            this.raio = raio;
        }

    //Método público CalcularVolume
    public double CalcularVolume()
        {
            double volume = 4.0 / 3.0 * Math.PI * Math.Pow(raio, 3.0);
            return volume;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o raio da esfera: ");
            double raio = double.Parse(Console.ReadLine());

        //Instância da classe Esfera + chamar método CalcularVolume calcular o volume 
        Esfera esfera = new Esfera(raio);
            double volume = esfera.CalcularVolume();

        //Exibe o resultado
            Console.WriteLine($"Volume da esfera: {volume:F2}");
        }
    }
