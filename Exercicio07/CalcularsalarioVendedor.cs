using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    internal class CalcularsalarioVendedor
    {
        private double salarioBase, totalVendas, comissaoVendedor;


        public CalcularsalarioVendedor(double salarioBase, double totalVendas)
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
}
