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
            var cliente = new Cliente();

            Assert.IsNull(cliente.Id);
            Assert.IsNull(cliente.Nome);
            Assert.IsNull(cliente.Sobrenome);
        }
    }
}