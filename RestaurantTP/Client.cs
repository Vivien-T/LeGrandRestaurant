using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantTP
{
    public class Client
    {
        public decimal MontantAPayer { get; private set; }
        public String Nom { get; private set; }

        public Client(string nom)
        {
            Nom = nom;
        }
        public void Commander(decimal montantCommande)
        {
            MontantAPayer += montantCommande;
        }
    }
}
