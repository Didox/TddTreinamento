using System;
using System.Collections.Generic;
using System.Text;

namespace TddConsole.Models
{
    public class Pedido
    {
        public Pedido()
        { 
        }

        public int Id { get; set; }
        public DateTime DtPedido { get; set; }
        public decimal Valor { get; set; }

        public IList<IProduto> Produtos { get; set; }
    }
}
