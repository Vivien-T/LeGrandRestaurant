using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantTP
{
    class Cuisine
    {
        public Restaurant Restaurant { get; private set; }
        public Cuisine(Restaurant resta)
        {
            Restaurant = resta;
        }

        public Produit changeStatut(Produit prod)
        {
            prod.Statut = "pret";
            return prod;
        }

    }
}
