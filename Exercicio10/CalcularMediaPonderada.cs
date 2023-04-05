using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    internal class CalcularMediaPonderada
    {
        private double nota1, nota2;
        private double peso1, peso2;

        public void SetNota1(double nota)
        {
            nota1 = nota;
        }

        public void SetNota2(double nota)
        {
            nota2 = nota;
        }

        public void SetPeso1(double peso)
        {
            peso1 = peso;
        }

        public void SetPeso2(double peso)
        {
            peso2 = peso;
        }

        public double GetMediaPonderada()
        {
            return (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);
        }
    }
}

