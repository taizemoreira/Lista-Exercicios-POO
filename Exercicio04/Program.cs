// 4) Crie um programa para calcular o consumo de combustível por Km. Deverá ser informado a
// kilometragem Inicial e Final do Percurso do  Veículo. Deverá ser informado o Consumo de Combustível 
using Exercicio04;
using System;
using System.Collections.Generic;
namespace ExConsumocombustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            //recebendo os valores do usuário, criando instância da classe Veiculo e chamando método CalcularConsumo 
            Console.Write("Digite a quiilometragem inicial: ");
            double kmInicial = double.Parse(Console.ReadLine());

            Console.Write("Digite a quilometragem final: ");
            double kmFinal = double.Parse(Console.ReadLine());

            Console.Write("Digite o consumo de combustível: ");
            double consumoCombustivel = double.Parse(Console.ReadLine());

            //Instância da classe Veiculo
            CalcularConsumoCombustivel veiculo = new CalcularConsumoCombustivel(kmInicial, kmFinal, consumoCombustivel);
            double consumo = veiculo.CalcularConsumo();

            //Retornando o resultado na tela
            Console.WriteLine($"Consumo de combustível por km: {consumo:F2}");
        }
    }
}