using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantTP
{
    class Franchise
    {


        public String nomFranchise { get; private set; }

        public Franchise(string nomFranchise, List<Restaurant> listeResto)
        {
            nomFranchise = listeResto;

            return nomFranchise;

        }

    }
}
