//10. Crie um programa para calcular a média ponderada de duas provas  realizadas por um aluno
using Exercicio10;
using System;
using System.Collections.Generic;
namespace ExMediaPonderada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("    CÁLCULO DA MÉDIA PONDERADA");
            Console.WriteLine("=====================================\n");

            CalcularMediaPonderada aluno = new CalcularMediaPonderada();

            Console.Write("Digite a nota da primeira prova: ");
            double nota1 = double.Parse(Console.ReadLine());
            aluno.SetNota1(nota1);

            Console.Write("Digite o peso da primeira prova: ");
            double peso1 = double.Parse(Console.ReadLine());
            aluno.SetPeso1(peso1);

            Console.Write("Digite a nota da segunda prova: ");
            double nota2 = double.Parse(Console.ReadLine());
            aluno.SetNota2(nota2);

            Console.Write("Digite o peso da segunda prova: ");
            double peso2 = double.Parse(Console.ReadLine());
            aluno.SetPeso2(peso2);

            double mediaPonderada = aluno.GetMediaPonderada();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n=========================================");
            Console.WriteLine("    RESULTADO DO CÁLCULO DA MÉDIA PONDERADA");
            Console.WriteLine("===========================================");
            Console.WriteLine("   Nota 1: {0, -10:0.00}  Peso 1: {1, -10:0.00}", nota1, peso1);
            Console.WriteLine("   Nota 2: {0, -10:0.00}  Peso 2: {1, -10:0.00}", nota2, peso2);
            Console.WriteLine("   Média ponderada: {0, -10:0.00}", mediaPonderada);
            Console.WriteLine("==========================================\n");
        }
    }
}