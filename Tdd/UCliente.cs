using NUnit.Framework;
using TddConsole.Models;

namespace Tdd
{
    public class UClienteOut
    {


        [Test]
        public void ValidarPropriedadesDeUmCliente()
        {
            var cliente = new Cliente();

            Assert.IsNull(cliente.Id);
            Assert.IsNull(cliente.Nome);
            Assert.IsNull(cliente.Sobrenome);
        }
    }
}