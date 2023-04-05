// 4) Crie um programa para calcular o consumo de combustível por Km. Deverá ser informado a
// kilometragem Inicial e Final do Percurso do  Veículo. Deverá ser informado o Consumo de Combustível 
using System;

    //Criando a classe Veiculo, declarando as variaveis: kilometragem Inicial, Final do Percurso e Consumo de Combustível 
    class Veiculo
    {
        private double kmInicial, kmFinal, consumoCombustivel;

        //Construtor da classe Veiculo --> recebe e armazena as variáveis
        public Veiculo(double kmInicial, double kmFinal, double consumoCombustivel)
        {
            this.kmInicial = kmInicial;
            this.kmFinal = kmFinal;
            this.consumoCombustivel = consumoCombustivel;
        }
        //Método público CalcularConsumo --> para calcular o consumo de combustível por km e retornar resultado.
        public double CalcularConsumo()
        {
            double kmPercorridos = kmFinal - kmInicial;
            double consumo = kmPercorridos / consumoCombustivel;
            return consumo;
        }
    }
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
            Veiculo veiculo = new Veiculo(kmInicial, kmFinal, consumoCombustivel);
            double consumo = veiculo.CalcularConsumo();

            //Retornando o resultado na tela
            Console.WriteLine($"Consumo de combustível por km: {consumo:F2}");
        }
    }