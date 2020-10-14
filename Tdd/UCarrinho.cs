using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using TddConsole.Models;
using TddConsole.Servicos;

namespace Tdd
{
    public class UCarrinho
    {

        private BancoEmMemoria _bancoEmMemoria;
        private Desejo _desejo;

        [SetUp]
        public void Setup()
        {
            this._bancoEmMemoria = new BancoEmMemoria();
            this._desejo = new Desejo();

        }

        [Test]
        public void ValidarPropriedadesDeUmCarrinho()
        {

            ListaDesejos lista = new ListaDesejos();
            lista.Desejos.Add(this._desejo);

            var dbRepositorio = new Database(lista, _bancoEmMemoria);
            dbRepositorio.Salvar();
            Assert.AreEqual(dbRepositorio.Quantidade(), 1);

        }

    }



    internal class Desejo
    {
        
    }
    internal class ListaDesejos  : IDoc
    {
        public List<Desejo> Desejos { get; set; }

        public ListaDesejos()
        {
            Desejos = new List<Desejo>();
        }

    }

    internal class BancoTemp : Db
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
