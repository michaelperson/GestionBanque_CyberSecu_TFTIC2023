using GestionBanque.Exemples;
using GestionBanque.Interfaces;
using GestionBanque.Models;
using System.Collections;

#region Exercices
Banque TfPognon = new Banque();
TfPognon.Nom = "FricSA";

Personne p1 = new Personne();
p1.Nom = "Pendragon";
p1.Prenom = "Arthur";
p1.DateNaiss = DateTime.Now;

Compte c1 = new Courant();
c1.Numero = "BE1234";
c1.Titulaire = p1;
c1.Depot(500);

c1.Retrait(1856);
//Je ne choisis pas le contexte de la demande de prêt
//c1.DemanderPret(1000);

//En tant que client je veux demander un prêt
((ICustomer)c1).DemandePret(1000);

//En tant que banquier je veux demander un prêt

((IBanker)c1).DemandePret(1000);






//Autre manière d'affecter des valeurs aux propriétés après instanciation de la classe
Compte c2 = new Epargne()
			 {
				 Numero = "BE456",
				 Titulaire = p1
			 };
c2.Depot(500.10);


TfPognon.Ajouter(c1);
TfPognon.Ajouter(c2);

TfPognon.AvoirDesCompte(p1);


 
 

try
{
	TfPognon.Ajouter(c1);
}
catch (InvalidProgramException ex)
{
	Console.WriteLine(ex.Message);
}

 


Console.WriteLine($"Le solde du compte {c1.Numero} de {c1.Titulaire.Nom} est de {c1.Solde}");

c1.Retrait(200);
Console.WriteLine($"Le solde du compte {c1.Numero} de {c1.Titulaire.Nom} est de {c1.Solde}");
c1.Retrait(500);
Console.WriteLine($"Le solde du compte {c1.Numero} de {c1.Titulaire.Nom} est de {c1.Solde}");

((Courant)c1).LigneDeCredit = 500;
c1.Retrait(1000);
Console.WriteLine($"Le solde du compte {c1.Numero} de {c1.Titulaire.Nom} est de {c1.Solde}");
#endregion

#region Exemples

//List<Forme> mesFormes = new List<Forme>();

//Forme f = new Rectangle();
//if (f is Triangle)
//{
//    (f as Triangle).A=8;
//}
//Triangle test = (f as Triangle)?? new Triangle() ;
//if(test != null)
//{
//    test.A = 15;
//    test.C = 15;
//    test.B = 25;
//}

//f.setNom("La triangle ?");
//mesFormes.Add(f);
//Rectangle r = new Rectangle();
//r.Larg = 4;
//r.Long= 5;
//r.setNom("Rectangle");
//mesFormes.Add(r);
//Carre c = new Carre();
//c.setNom("Carré");
//c.Long = 8;

//mesFormes.Add(c);
//Triangle t = new Triangle();
//t.A = 14;
//t.B=15;
//t.C = 16;
//mesFormes.Add(t);

//foreach (Forme item in mesFormes)
//{
//    Console.WriteLine(item.getNom());
//   // if(item is Rectangle)  ((Rectangle)item).Aire();

//    Console.WriteLine($"Aire : {item.Aire()}");

//} 
#endregion

 