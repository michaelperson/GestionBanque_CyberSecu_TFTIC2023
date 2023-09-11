using GestionBanque.Models;

Banque TfPognon = new Banque();
TfPognon.Nom = "FricSA";

Personne p1 = new Personne();
p1.Nom = "Pendragon";
p1.Prenom = "Arthur";
p1.DateNaiss = DateTime.Now;

Courant c1 = new Courant();
c1.Numero = "BE1234";
c1.Titulaire = p1;
c1.Depot(500);

//Autre manière d'affecter des valeurs aux propriétés après instanciation de la classe
Courant c2 = new Courant()
{
	Numero = "BE456",
	Titulaire = p1
};
c2.Depot(500.10);
 

TfPognon.Ajouter(c1);
TfPognon.Ajouter(c2);

double MonArgent = c1 + c2; 
Console.WriteLine($"Total de mes avoirs : {MonArgent} €");

try
{
	TfPognon.Ajouter(c1);
}
catch (InvalidProgramException ex)
{
	Console.WriteLine(ex.Message);
}

Courant? recup = TfPognon["BE1234"]; 


Console.WriteLine($"Le solde du compte {c1.Numero} de {c1.Titulaire.Nom} est de {c1.Solde}");

c1.Retrait(200);
Console.WriteLine($"Le solde du compte {c1.Numero} de {c1.Titulaire.Nom} est de {c1.Solde}");
c1.Retrait(500);
Console.WriteLine($"Le solde du compte {c1.Numero} de {c1.Titulaire.Nom} est de {c1.Solde}");

c1.LigneDeCredit = 500;
c1.Retrait(1000);
Console.WriteLine($"Le solde du compte {c1.Numero} de {c1.Titulaire.Nom} est de {c1.Solde}");
