using GestionBanque.Exceptions;
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
        public override double taux_interet
        {
            get
            {
                return 0.45;
            }

             
        }

        public DateTime DateDernierRetrait { get; private set; }

    

        #endregion

        #region Constructors
        public Epargne(string numero, Personne titulaire) : base(numero, titulaire)
        {
        }

        public Epargne(string numero, Personne titulaire, double solde) : base(numero, titulaire, solde)
        {
        }
        #endregion


        #region Methods
        public override void Retrait(double Montant)
        {
            if (Solde - Montant < 0) throw new SoldeInsuffisantException();
           
            base.Retrait(Montant); //Seul le parent a le droit de modifier le solde :)
            DateDernierRetrait= DateTime.Now;
        }

        protected override double CalculerInteret()
        {
            return taux_interet;
        }

        #endregion
    }
}
