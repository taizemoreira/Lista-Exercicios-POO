// Crie um programa para converter a temperatura de graus Fahrenheit para  graus Celsius 
using Exercicio02;
namespace ExConversaoTemperaturaCelcius
{  
    public class Program
    {
        //Ler a temperatura em Fahrenheit e criar uma instância da classe Temperatura 
        static void Main(string[] args)
        {
            Console.WriteLine("================================");
            Console.WriteLine("  CONVERSÃO DE TEMPERATURA");
            Console.WriteLine("================================\n");

            Console.Write("Digite a temperatura em graus Fahrenheit: ");
            double temperaturaFahrenheit = double.Parse(Console.ReadLine());

            ConversaoParaCelcius temperatura = new ConversaoParaCelcius(temperaturaFahrenheit);
            double temperaturaCelsius = temperatura.FahrenheitParaCelsius();

            Console.WriteLine($"Temperatura em graus Celsius: {temperaturaCelsius:F2}");
        }
    }
}
