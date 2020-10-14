using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TddConsole.Data;
using TddConsole.Servicos.Intefaces;

namespace TddConsole.Servicos
{
    public class StoreServicesCaches : IStoreServicesCache
    {
        StoreCache Data = new StoreCache();
        public StoreServicesCaches(StoreCache store)
        {
            Data = store;
        }
        public bool AddCache(string cache)
        {
            Data.AddCache(cache);
            return true;
        }

        public List<string> SelectCache()
        {
            return Data.SelectCache();
        }
    }
}
