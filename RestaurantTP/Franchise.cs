using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantTP
{
    public class Franchise
    {


        public string Nom { get; private set; }
        public List<Restaurant> ListeResto { get; private set; } = new List<Restaurant>();

        public Franchise(string nom, List<Restaurant> listeResto)
        {
            Nom = nom;
            ListeResto = listeResto;
        }

    }
}
