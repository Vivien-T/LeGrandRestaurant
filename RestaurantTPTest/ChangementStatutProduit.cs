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
            List<Serveur> list = new List<Serveur>();
            Restaurant restaurant = new Restaurant("Le Resto", list);
            Cuisine cuisine = new Cuisine(restaurant);
            Produit pizza = new Produit(15, "Pizza", 4);

            cuisine.changeStatut(pizza);

            Assert.Equal("pret", pizza.Statut);
        }
    }
}
