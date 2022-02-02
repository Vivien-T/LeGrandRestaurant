using System;
using System.Collections.Generic;
using System.Text;
using RestaurantTPTest.utilities;
using Xunit;

namespace RestaurantTPTest
{
    public class CuisineTest
    {
        [Fact]
        public void Produit_bien_créé_avec_statut_non_pret()
        {
            var cuisine = new CuisineBuilder().Creer("resto1").Build();
            Assert.NotEqual(null, cuisine.Restaurant);
        }
    }
}
