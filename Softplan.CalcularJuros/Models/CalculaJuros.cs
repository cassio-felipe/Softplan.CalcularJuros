using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Softplan.CalcularJuros.Models
{
    public class CalculaJuros : ICalculaJuros
    {
        public decimal CalcularJuros(decimal ValorInicial, int meses)
        {
            var valorFinal = ((double)ValorInicial * Math.Pow(1 + 0.01, meses)).ToString("F");
            return Convert.ToDecimal(valorFinal);
        }
    }
}
