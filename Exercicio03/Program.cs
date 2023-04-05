// 3) Crie um programa para calcular o volume de um Cilindro 
using System;

//Criamos a classe Cilindro
    public class Cilindro
    {
        private double raio;
        private double altura;

        //Construtor da classe Cilindro
        public Cilindro(double raio, double altura)
        {
            this.raio = raio;
            this.altura = altura;
    }

        //A classe Cilindro possui um método público CalcularVolume
        public double CalcularVolume()
        {
            double volume = Math.PI * Math.Pow(raio, 2) * altura;
            return volume;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o raio do cilindro: ");
            double raio = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura do cilindro: ");
            double altura = double.Parse(Console.ReadLine());


            //Criando instância da classe Cilindro e chamando o método CalcularVolume da instância para calcular o volume
            Cilindro cilindro = new Cilindro(raio, altura);
            double volume = cilindro.CalcularVolume();

            Console.WriteLine($"Volume do cilindro: {volume:F2}");
        }
    }
