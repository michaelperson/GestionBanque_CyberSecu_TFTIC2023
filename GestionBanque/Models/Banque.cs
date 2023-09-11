using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanque.Models
{
    internal class Banque
    {
        #region Fields
        private Dictionary<string, Courant> _comptes = new Dictionary<string, Courant>(); //Key= Numéro de compte 
        #endregion
        #region Properties
        public Courant? this[string numero]
        {
            get
            {

                return _comptes.TryGetValue(numero, out Courant? courant) ? courant : null;
            }
            private set
            {
                _comptes[numero] = value;
            }
        }
        public string Nom { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Permet d'ajouter un compte à la banque
        /// </summary>
        /// <param name="c">Le compte a ajouter <see cref="Courant"/></param>
        /// <exception cref="Exception">Sera lancée si le compte est déjà présent dans la banque</exception>
        public void Ajouter(Courant c)
        {
            //Est-ce que le compte est déjà présent ?
            if (!_comptes.ContainsKey(c.Numero))
            {
                //NON -> Je l'ajouter via l'indexeur
                this[c.Numero] = c;
            }
            else
            {
                //Oui -> je balance une exception pour que le code appelant puisse prévenir le user
                throw new InvalidProgramException($"Le compte {c.Numero} est déjà présent!");
            }
        }


        public void Supprimer(string numero)
        {
            //Est-ce que le compte est déjà présent ?
            if (_comptes.ContainsKey(numero))
            {
                //Si oui ==> DESTRUCTION!!!
                _comptes.Remove(numero);
            }
            else
            {
                //Sinon on prévient l'extérieur
                throw new InvalidProgramException($"Ce compte {numero} n'existe pas!");
            }
        } 

        public double AvoirDesCompte(Personne titus)
        {
            double sommes = 0;
            ///parcourir mes comptes
            ///si titulaire = titus
            // Ajouter les soles
            
            foreach (KeyValuePair<string,Courant> item in _comptes)
            {
                //PAUSE ?
                if(item.Value.Titulaire==titus)
                {  // double = double + Courant(obj)       
                    sommes = (item.Value + sommes);
                }
            }
            return sommes;
        }
        #endregion
    }
}
