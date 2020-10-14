using NUnit.Framework;

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
        public void ValidarPropriedadesDeUmClienteNaoNull()
        {
            var cliente = _mock.ClienteMockado();

            Assert.IsNotNull(cliente.Id);
            Assert.IsNotNull(cliente.Nome);
            Assert.IsNotNull(cliente.Sobrenome);
        }
        
        [Test]
        public void ValidarPropriedadesDeUmClienteNull()
        {
            var cliente = _mock.ClienteMockadoNull();

            Assert.IsNull(cliente.Id);
            Assert.IsNull(cliente.Nome);
            Assert.IsNull(cliente.Sobrenome);
        }
    }
}