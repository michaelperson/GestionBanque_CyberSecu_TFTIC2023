using GestionBanque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanque.Exceptions
{
    internal class LigneDeCreditException : Exception
    {
        public LigneDeCreditException(Personne titu, string Message):  base(Message, new InvalidOperationException(titu.Nom))
        {
              
            //logique locale business
        }

        public override string Message
        {
            get
            {
                return $"{DateTime.Now.ToLongDateString()} {base.Message}";
            }
             
        }
    }
}
