using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TddConsole.Models;
using TddConsole.Servicos;

namespace Tdd
{
    public class UEmailService
    {
        
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void ValidaEnvioEmailCliente()
        {
            var cliente = new Pessoa();            
            cliente.Email = "hugo@teste.com.br";

            var serviceEmail = new ServiceEmail();

            Assert.IsTrue(serviceEmail.Sender(cliente));
        }

        [Test]
        public void ValidaEnvioEmailPessoaSemEmail() 
        {
            var cliente = new Pessoa();            

            var serviceEmail = new ServiceEmail();

            Assert.IsFalse(serviceEmail.Sender(cliente));
        }

        internal class Pessoa : IPessoa
        {
            public string Email { get; set; }
        }

        internal class ServiceEmail : EmailService
        {
            public override bool Sender(IPessoa pessoa)
            {
                if (string.IsNullOrEmpty(pessoa.Email))
                    return false;

                return true;
            }
        }
    }
}
