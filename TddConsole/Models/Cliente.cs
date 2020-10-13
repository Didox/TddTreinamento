using System;
using TddConsole.Servicos;

namespace TddConsole.Models
{
	public class Cliente : IDoc
	{
		public Cliente()
		{
		}

		public int? Id { get; set; }
		public string Nome { get; set; }
		public string Sobrenome { get; set; }        

        public void Salvar(Db db)
        {
			db.Salvar(this);
        }
	}
}
