using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExMediaHarmonica
{
    internal class CalcularMediaHarmonicadoAluno
    {
            //Construtor da classe --> recebe as notas em um array
            private double[] notas;

            public CalcularMediaHarmonicadoAluno(double[] notas)
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
}

