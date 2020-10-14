using System.Collections.Generic;
using NUnit.Framework;
using TddConsole.Models;
using TddConsole.Servicos;

namespace Tdd
{
    public class UDatabase
    {
        private BancoEmMemoria _bancoEmMemoria;

        [SetUp]
        public void Setup()
        {
            this._bancoEmMemoria = new BancoEmMemoria();
        }

        [Test]
        public void SalvarDadoMemoria()
        {
            var dbRepositorio = new Database(new Pessoa(), _bancoEmMemoria);
            dbRepositorio.Salvar();
            Assert.AreEqual(dbRepositorio.Quantidade(), 1);
        }
    }

    internal class Pessoa : IDoc
    {
        public string CPF { get; set; }
    }

    internal class BancoEmMemoria : Db
    {
        private List<IDoc> _documentos = new List<IDoc>();

        public override int Quantidade()
        {
            return _documentos.Count;
        }

        public override void Salvar(IDoc iDoc)
        {
            _documentos.Add(iDoc);
        }

        public override List<IDoc> Todos()
        {
            return _documentos;
        }
    }
}