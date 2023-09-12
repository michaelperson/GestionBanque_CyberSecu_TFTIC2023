using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanque.Models
{
    internal class Compte
    {
        #region Props
        public string Numero { get; set; }
        public double Solde { get; private set; }
        public Personne Titulaire { get; set; }
        #endregion


        #region Methods
        public void Depot(double Montant)
        {
            if (Montant < 0) throw new InvalidOperationException("Le montant doit être positif");
            Solde += Montant;
        }

        public virtual void Retrait(double Montant)
        {
            if (Montant < 0) throw new InvalidOperationException("Le montant doit être positif");
            Solde -= Montant;
        }
        #endregion

        #region Surcharge D'opérateur
        public static double operator +(Compte toto, double lasomme)
        {
            return (toto.Solde > 0 ? toto.Solde : 0) + lasomme;
        } 
        #endregion
    }
}
