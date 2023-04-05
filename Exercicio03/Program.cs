// 3) Crie um programa para calcular o volume de um Cilindro 
using Exercicio03;
namespace ExVolumeDoCilindro
{

    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o raio do cilindro: ");
            double raio = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura do cilindro: ");
            double altura = double.Parse(Console.ReadLine());


            //Criando instância da classe Cilindro e chamando o método CalcularVolume da instância para calcular o volume
            CalcularVolumeCilindro cilindro = new CalcularVolumeCilindro(raio, altura);
            double volume = cilindro.CalcularVolume();

            Console.WriteLine($"Volume do cilindro: {volume:F2}");
        }
    }
}
