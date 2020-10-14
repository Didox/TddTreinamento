using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TddConsole.Servicos.Intefaces
{
    public interface IStoreServicesCache
    {
        bool AddCache(string cache);
        List<string> SelectCache();
    }
}
