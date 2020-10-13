using System;
using TddConsole.Servicos;

namespace TddConsole.Models
{
	public class Estoque : IDoc
	{
		public Estoque()
		{
		}

		public IProduto produto { get; set; }
		public int qtdatual { get; set; }
        public int qtdminima { get; set; }

		public void Salvar(Db db)
        {
			db.Salvar(this);
        }

        public void ContaEstoque(Db db)
        {
			db.Salvar(this);
        }
	}
}
