using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Softplan.CalcularJuros.Models;

namespace Softplan.CalcularJuros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalcularJurosController : ControllerBase
    {
        public ICalculaJuros _valores { get; set; }

        public CalcularJurosController(ICalculaJuros valores)
        {
            _valores = valores;
        }

        [HttpGet]
        public IActionResult CalcularJuros(decimal valorInicial, int tempo)
        {
            var calcular = _valores.CalcularJuros(valorInicial, tempo);

            return Ok(calcular);

        }
    }
}