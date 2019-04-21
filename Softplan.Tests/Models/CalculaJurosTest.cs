﻿using Softplan.CalcularJuros.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Softplan.Tests.Models
{
    public class CalculaJurosTest
    {
        [Fact]
        public void DeveCalcularOsJurosCorretamente()
        {
            var calculoJuros = new CalculaJuros().CalcularJuros(100, 5);
            Assert.Equal(105.10m, calculoJuros);
        }

        [Fact]
        public void DeveRetornarJurosComParametrosZerados()
        {
            var calculoJuros = new CalculaJuros().CalcularJuros(100, 0);
            Assert.Equal(0, calculoJuros);

            calculoJuros = new CalculaJuros().CalcularJuros(0, 5);
            Assert.Equal(0, calculoJuros);
        }
    }
}
