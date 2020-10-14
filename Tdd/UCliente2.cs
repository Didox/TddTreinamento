using NUnit.Framework;
using TddConsole.Models;

namespace Tdd
{
    public class UCliente2
    {
        private UClienteFactory _mock;
        
        [SetUp]
        public void Setup()
        {
            _mock = UClienteFactory.Instance;
        }

        [Test]
        public void ValidarPropriedadesDeUmClienteAtributosNaoNull()
        {
            var cliente = _mock.ClienteMockado();

            Assert.IsNotNull(cliente.Id);
            Assert.IsNotNull(cliente.Nome);
            Assert.IsNotNull(cliente.Sobrenome);
        }
        
        [Test]
        public void ValidarPropriedadesDeUmClienteAtributosNull()
        {
            var cliente = _mock.ClienteMockadoNull();

            Assert.IsNull(cliente.Id);
            Assert.IsNull(cliente.Nome);
            Assert.IsNull(cliente.Sobrenome);
        }

        [Test]
        public void ValidarCriacaoDeUmCliente()
        {
            var cliente = _mock.ClienteMockado();
            
            Assert.IsNotNull(cliente);
            Assert.IsInstanceOf<Cliente>(cliente);
        }
        
        [Test]
        public void ValidarCriacaoDeUmClienteAtributosNull()
        {
            var cliente = _mock.ClienteMockadoNull();
            
            Assert.IsNotNull(cliente);
            Assert.IsInstanceOf<Cliente>(cliente);
        }
    }
}