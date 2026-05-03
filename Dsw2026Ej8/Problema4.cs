using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            int sumaNotas = 0;
            int cantidadNotasValidas = 0;

            if (nota1.HasValue && nota1.Value >= 0 && nota1.Value <= 10)
            {
                sumaNotas += nota1.Value;
                cantidadNotasValidas++;
            }
            if (nota2.HasValue && nota2.Value >= 0 && nota2.Value <= 10)
            {
                sumaNotas += nota2.Value;
                cantidadNotasValidas++;
            }

            if (nota3.HasValue && nota3.Value >= 0 && nota3.Value <= 10)
            {
                sumaNotas += nota3.Value;
                cantidadNotasValidas++;
            }

            if (cantidadNotasValidas == 0)
            {
                return 0;
            }

            return (double)sumaNotas / cantidadNotasValidas;
        }
    }
}
