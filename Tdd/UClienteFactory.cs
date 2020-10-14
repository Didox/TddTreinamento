using System;
using System.Collections.Generic;
using TddConsole.Models;

/*
 Elmon - Criar um fatore para salvar e buscar objetos com o teste 
 Objeto cliente
*/

namespace Tdd
{
    public sealed class UClienteFactory
    {
        private static UClienteFactory _instance = null;

        private List<string> _nomes;

        private List<string> _sobrenomes;

        private Random _random;

        UClienteFactory()
        {
            _nomes = new List<string>() {"Danilo", "Elmon", "Marco"};
            _sobrenomes = new List<string>() {"Santos", "Noronha", "Tomaz"};
            _random = new Random();
        }

        public static UClienteFactory Instance
        {
            get { return _instance ?? (_instance = new UClienteFactory()); }
        }

        public Cliente ClienteMockado()
        {
            var tmp = new Cliente();
            tmp.Id = _random.Next();
            tmp.Nome = _nomes[_random.Next(0, 2)];
            tmp.Sobrenome = _sobrenomes[_random.Next(0, 2)];
            return tmp;
        }

        public Cliente ClienteMockadoNull()
        {
            var tmp = new Cliente();
            return tmp;
        }
    }
}