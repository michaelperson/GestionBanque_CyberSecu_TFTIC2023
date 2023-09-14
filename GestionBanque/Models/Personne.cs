using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanque.Models
{
    public class Personne
    {
        #region Champs privés
       // private string _nom;
        private string _prenom;
        private DateTime _dateNaiss; 
        private DateTime now;

        
        #endregion

        #region accesseurs de champ privé
        public string Nom
        {
            get;
            //private set { _nom = value; }
            init;
        }

        public string Prenom
        {
            get { return _prenom; }
             set { _prenom = value; }
        }

        public DateTime DateNaiss
        {
            get { return _dateNaiss; }
            private set { _dateNaiss = value; }
        }

        #endregion

        #region Constructors
        public Personne(  string prenom, DateTime datenaiss)
        {
             
            Prenom = prenom;
            DateNaiss = datenaiss;
        } 
        #endregion

         
         
    }
}
