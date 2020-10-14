using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddConsole.Data
{
    public class StoreCache
    {
        private List<string> Data = new List<string>();
        public bool AddCache(string cache)
        {
            Data.Add(cache);
            return true;
        }

        public List<string> SelectCache()
        {
            return Data;
        }
    }
}
