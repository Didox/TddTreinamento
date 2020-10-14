using System;
using TddConsole.Servicos;

namespace TddConsole.Models
{
	public class Estoque : IDoc 
	{
		public Estoque()
		{
		}

		public IProduto Produto { get; set; }
		public int QtdAtual { get; set; }
       		public int QtdMinima { get; set; }

		public void Salvar(Db db)
        	{
			db.Salvar(this);
        	}

        	public void ContaEstoque(Db db)
        	{
			var list = db.Todos();
           		int Qtd = 0;
			foreach (var p in list)
			{
			//Aqui será implementado uma contagem do estoque desse produto

			}
        	}
	}
}
