using System.Linq;
using RestaurantTPTest.utilities;
using RestaurantTP;
using Xunit;
using System.Collections.Generic;

namespace RestaurantTPTest
{
    public class ChangementStatutProduit
    {
        [Fact]
        public void Cuisine_change_statut_produit()
        {
            Restaurant restaurant = new Restaurant("Le Resto");
            Cuisine cuisine = new Cuisine(restaurant);
            Produit pizza = new Produit(15, "Pizza", 4);

            Cuisine.changeStatut(pizza);

            Assert.Equal("pret", pizza.Statut);
        }
    }
}
