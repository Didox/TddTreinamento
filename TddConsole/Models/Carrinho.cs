using System;
using System.Collections.Generic;
using System.Text;
using TddConsole.Servicos;

namespace TddConsole.Models
{
    public class Carrinho : IDoc
    {
        public Cliente Cliente { get; set; }
        public List<Produto> Produto { get; set; }

        public void Salvar(Db db)
        {
            db.Salvar(this);
        }
    }
}
