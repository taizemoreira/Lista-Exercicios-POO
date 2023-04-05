// 9) Crie um programa para calcular a média harmônica das notas de um  aluno 
using System;

//criação da classe
class Aluno
{
    //Construtor da classe --> recebe as notas em um array
    private double[] notas;

    public Aluno(double[] notas)
    {
        this.notas = notas;
    }

    //Metodo para calcular a media harmonica
    public double CalcularMediaHarmonica()
    //solicitar as notas e armazená-las
    {
        double somaInversos = 0.0;

        foreach (double nota in this.notas)
        {
            somaInversos += 1 / nota;
        }

        return this.notas.Length / somaInversos;
    }
}

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
        Aluno aluno = new Aluno(notas);

        //Método para calcular a média harmonica
        double mediaHarmonica = aluno.CalcularMediaHarmonica();


        //Retornando o resultado para o usuário
        Console.WriteLine("\nA média harmônica das notas é: {0:0.00}", mediaHarmonica);
    }
}
