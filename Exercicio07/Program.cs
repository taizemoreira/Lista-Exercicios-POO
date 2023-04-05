//Crie um programa para calcular o salário total de um vendedor.
//Deverá  ser informado o salário base e o total de vendas. A comissão é calculada  com um percentual (informado pelo usuário) sobre o total de vendas.  
using System;

class Vendedor
{
    private double salarioBase, totalVendas, comissaoVendedor;
    

    public Vendedor(double salarioBase, double totalVendas)
    {
        this.salarioBase = salarioBase;
        this.totalVendas = totalVendas;
    }

    public void CalcularComissao(double percentualComissao)
    {
        this.comissaoVendedor = this.totalVendas * percentualComissao / 100;
    }

    public double SalarioTotal()
    {
        return this.salarioBase + this.comissaoVendedor;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("*****************************");
        Console.WriteLine("**** CÁLCULO DO SALÁRIO ****");
        Console.WriteLine("*****************************\n");

        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Digite o salário base do vendedor: ");
        double salarioBase = double.Parse(Console.ReadLine());

        Console.Write("Digite o total de vendas do vendedor: ");
        double totalVendas = double.Parse(Console.ReadLine());

        Console.Write("Digite o percentual de comissão sobre as vendas (ex: 10 para 10%): ");
        double percentualComissao = double.Parse(Console.ReadLine());

        Vendedor vendedor = new Vendedor(salarioBase, totalVendas);
        vendedor.CalcularComissao(percentualComissao);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nO salário total do vendedor é de: R${0:0.00}", vendedor.SalarioTotal());

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n*****************************");
        Console.WriteLine("**** OBRIGADO POR USAR! ****");
        Console.WriteLine("*****************************");

        Console.ResetColor();
    }
}
