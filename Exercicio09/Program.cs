// 9) Crie um programa para calcular a média harmônica das notas de um  aluno 
using Exercicio09;
using System;
using System.Collections.Generic;
namespace ExMediaHarmonica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============================");
            Console.WriteLine("CALCULO DA MEDIA HARMÔNICA\n");
            Console.WriteLine("==============================\n");

            Console.Write("Quantas notas o aluno possui? ");
            int quantidadeNotas = int.Parse(Console.ReadLine());

            //solicitar as notas acima e armazena-las no array abaixo
            double[] notas = new double[quantidadeNotas];

            for (int i = 0; i < quantidadeNotas; i++)
            {
                Console.Write("Digite a nota {0}: ", i + 1);
                notas[i] = double.Parse(Console.ReadLine());
            }

            //Criando a instância com as notas 
            CalcularMediaHarmonicadoAluno aluno = new CalcularMediaHarmonicadoAluno(notas);

            //Método para calcular a média harmonica
            double mediaHarmonica = aluno.CalcularMediaHarmonica();


            //Retornando o resultado para o usuário
            Console.WriteLine("\nA média harmônica das notas é: {0:0.00}", mediaHarmonica);
        }
    }
}
