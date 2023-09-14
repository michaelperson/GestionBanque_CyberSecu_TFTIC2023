using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanque.Exceptions
{
    internal class SoldeInsuffisantException : Exception
    {
        public SoldeInsuffisantException(string message): base(message)
        {

        }
    }
}
