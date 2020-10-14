using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TddConsole.Models;

namespace Tdd
{
    public class UPedido
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ValidarPropriedadesDeUmPedido()
        {
            var pedido = new Pedido();

            Assert.Zero(pedido.Id);
            Assert.NotNull(pedido.DtPedido);
            Assert.Zero(pedido.Valor);
            Assert.IsNull(pedido.Produtos);
        }

        [Test]
        public void CriaUmPedidoValido()
        {
            var produtos = new List<IProduto>();

            var pedido = new Pedido
            { 
                Id = 1,
                DtPedido = DateTime.Now,
                Valor = 100,
                Produtos = produtos
            };

            Assert.IsNotNull(pedido);
            Assert.IsNotNull(pedido.Produtos);
        }
    }
}
