using NUnit.Framework;
using TddConsole.Models;

namespace Tdd
{
    public class UProduto
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ValidarPropriedadesDeUmProtudo()
        {
            var produto = new Produto();

            Assert.IsNull(produto.Id);
            Assert.IsNull(produto.Nome);
            Assert.IsNull(produto.Sobrenome);
        }
    }
}