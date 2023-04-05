//1) Utilizando Orientação a Objetos, crie um programa para calcular o volume de uma caixa retangular 
using System;
namespace ExCaixaRetangular
{
   public class CaixaRetangular
   {
        //Variáveis
        double comprimento, largura, altura;
        public static void main(String[] args)
        {
            Console.Write("Informe o comprimento da caixa: ");
            double comprimento = double.Parse(Console.ReadLine());

            Console.Write("Informe a largura da caixa: ");
            double largura = double.Parse(Console.ReadLine());

            Console.Write("Informe a altura da caixa: ");
            double altura = double.Parse(Console.ReadLine());

            CaixaRetangular caixa = new CaixaRetangular(comprimento, largura, altura);
        }

        //Construtor que recebe o comprimento, largura e altura da caixa
        public CaixaRetangular(double comprimento, double largura, double altura)
        {
            this.comprimento = comprimento;
            this.largura = largura;
            this.altura = altura;
        }

        //Método Volume() que calcula e retorna o volume da caixa
        public double Volume()
        {
            return comprimento * largura * altura;
        }
    }
 
        //Instância da classe CaixaRetangular
        class Program
        {
            static void Main(string[] args)
            {
                CaixaRetangular caixa = new CaixaRetangular();
                double volume = caixa.Volume();
                Console.WriteLine("O volume da caixa é: " + volume);
            }
        }
}






    