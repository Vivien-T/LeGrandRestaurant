using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantTP
{
    class Franchise
    {


        public string NomFranchise { get; private set; }
        public List<Restaurant> ListeResto { get; private set; }

        public Franchise(string nomFranchise, List<Restaurant> listeResto)
        {
            NomFranchise = nomFranchise;
            ListeResto = listeResto;
        }

    }
}
