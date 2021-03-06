﻿using System;
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
        [ProducesResponseType(statusCode: 200, type: typeof(decimal))]
        public IActionResult CalcularJuros(decimal valorInicial, int meses)
        {
            var calcular = _valores.CalcularJuros(valorInicial, meses);
            return Ok(calcular);

        }
    }
}