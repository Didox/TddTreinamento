using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Text;
using TddConsole.Data;
using TddConsole.Servicos;

namespace Tdd
{
    public class UStoreServicesCache
    {
        private StoreServicesCaches services;
        [SetUp]
        public void Setup()
        {
           var Data = new StoreCache();
            services = new StoreServicesCaches(Data);
        }

        [Test]
        public void ArmazenarCache()
        {
            var result = services.AddCache("Teste de cache 01");
            Assert.AreEqual(true, services.SelectCache().Contains("Teste de cache 01"));
        }

        [Test]
        public void RetornarCache()
        {
            var result = services.SelectCache();
            Assert.AreNotEqual(result, null);
        }
    }
}
