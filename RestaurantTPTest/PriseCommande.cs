using System.Linq;
using RestaurantTPTest.utilities;
using RestaurantTP;
using Xunit;
using System.Collections.Generic;

namespace RestaurantTPTest
{
    public class PriseCommande
    {
        [Fact]
        public void Serveur_prend_commande_a_un_client()
        {
            Client damien = new Client("Damien");
            Serveur serge = new Serveur("Serge");
            Produit pizza = new Produit(15, "Pizza", 4);
            Produit tiramisu = new Produit(4, "Tiramisu", 2);
            List<Produit> listeProduits = new List<Produit>(){pizza, tiramisu};

            Commande commande = serge.PrendreCommande(damien, listeProduits);

            Assert.Equal(pizza.Prix + tiramisu.Prix, serge.ChiffreAffaires);
            Assert.Equal(commande.LeClient, damien);
            Assert.Equal(commande.LeServeur, serge);
            Assert.Equal(commande.LesProduits, listeProduits);
        }

    }
}
