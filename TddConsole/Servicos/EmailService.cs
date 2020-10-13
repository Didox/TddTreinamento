using System;
using System.Collections.Generic;
using System.Text;
using TddConsole.Models;

namespace TddConsole.Servicos
{
    public abstract class EmailService
    {

        public abstract bool Sender(IPessoa pessoa);         
    }
}
