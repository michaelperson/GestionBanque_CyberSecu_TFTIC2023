using GestionBanque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanque.Interfaces
{
    internal interface IBanker : ICustomer
    {
        Personne Titulaire { get; }
        string Numero { get; }
         

        void AppliquerInteret();

        bool DemandePret(double Montant);
    }
}
