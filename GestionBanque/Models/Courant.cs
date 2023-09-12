using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanque.Models
{
    internal class Courant : Compte
    {
        #region Champs privés 
        private double _ligneDeCredit;

        #endregion
        public static double Interet;
        //raccourci pour auto-prop => taper prop > tab
        //produit le même résultat qu'une propfull à la compilation
        //il s'agit juste d'un raccourci d'écriture
        
        #region Propriétés     


        public double LigneDeCredit
        {
            get { return _ligneDeCredit; }
            set
            {
                if (value > 0)
                {
                    _ligneDeCredit = value;
                }
            }
        }

   

        #endregion

        #region Methodes
        public override void Retrait(double Montant)
        {

             
                if (Montant <= Solde + LigneDeCredit)
                   base.Retrait(Montant);
                else Console.WriteLine("Solde insuffisant");
             

        }
        protected override double CalculerInteret()
        {
            return Solde >0? 0.3 : 0.975;
        }

        #endregion

        #region Surcharge Operators

        public static double operator +(Courant c1, Courant c2)
        {
            //Clair préci, rapide et maintenable
            //if (c1.Solde < 0 && c2.Solde >= 0) return c2.Solde;
            //if (c2.Solde < 0 && c1.Solde >= 0) return c1.Solde;
            //if (c2.Solde < 0 && c1.Solde < 0) return 0;
            //return c1.Solde + c2.Solde;

            //Top puisque c'est moi qui l'ai écrit :p
            return (c1.Solde > 0 ? c1.Solde : 0) + (c2.Solde > 0 ? c2.Solde : 0);
           
            
            //Joli pour le style mais non maintenable
            // return (c1.Solde < 0 && c2.Solde >= 0) ? c2.Solde : c2.Solde < 0 && c1.Solde >= 0 ? c1.Solde : c2.Solde < 0 && c1.Solde < 0 ? 0 : c1.Solde + c2.Solde;

        }

        

        #endregion
    }
}
