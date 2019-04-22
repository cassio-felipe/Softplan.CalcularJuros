using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Softplan.CalcularJuros.Models
{
    public interface ICalculaJuros
    {
        decimal CalcularJuros(decimal ValorInicial, int meses);
    }
}
