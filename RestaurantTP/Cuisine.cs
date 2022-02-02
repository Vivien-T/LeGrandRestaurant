using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantTP
{
    public class Cuisine
    {
        public Restaurant Restaurant { get; private set; }
        public Cuisine(Restaurant resto)
        {
            Restaurant = resto;
        }

        public Produit changeStatut(Produit prod)
        {
            prod.Statut = "pret";
            return prod;
        }

    }
}
