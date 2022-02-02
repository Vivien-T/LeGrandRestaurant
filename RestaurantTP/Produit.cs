using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantTP
{
    public class Produit
    {

        public float Prix { get; private set; }
        public string Nom { get; private set; }
        public int Stock { get; private set; }
        public string Statut { get; set; }

        public Produit(float prix, string nom, int stock)
        {
            Prix = prix;
            Nom = nom;
            Stock = stock;
            Statut = "non prêt";
        }

    }
}
