using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanque.Exemples
{
    internal abstract class Forme : IForme
    {
        protected string Nom { get; set; }
        public void setNom(string n)
        {
            this.Nom = n;
        }

        public string getNom() { return $"Nom :{this.Nom}"; }

        public abstract int Aire();//Méthode sans code, obligeant les enfants de créer la logique de la fonction  avec leur propre code
    }

    internal class Rectangle :  Forme
    {
         public int Long { get; set; }
        public int Larg { get; set; }
        public override int Aire()
        {

            return (Long * Larg);
        }

    }

    internal class Carre : Rectangle
    {
        public override int Aire()
        {
            return (Long * Long) ;
        }

    }

    internal sealed class Triangle : Forme
    {
        public int A { get; set; }
        public int B { get; set; }

        public int C { get; set; }

        public override int Aire()
        {
            return (A * B) / 2;
        }
    }

     
}
