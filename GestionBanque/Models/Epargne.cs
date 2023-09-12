using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanque.Models
{
    internal class Epargne : Compte
    {
        #region Props
     
     
        public DateTime DateDernierRetrait { get; set; }
     
        #endregion

        #region Methods
        public override void Retrait(double Montant)
        {
           
            if (Solde - Montant < 0) throw new InvalidOperationException("Solde insuffisant");
            base.Retrait(Montant); //Seul le parent a le droit de modifier le solde :)
            DateDernierRetrait= DateTime.Now;
        }
        
        #endregion
    }
}
