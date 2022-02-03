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
            Client jeanne = new Client("Jeanne");

            Serveur serge = new Serveur("Serge");
            Serveur patrick = new Serveur("Patrick");

            Produit pizza = new Produit(15, "Pizza", 4);
            Produit tiramisu = new Produit(4, "Tiramisu", 2);
            Produit crepe = new Produit(10, "Crepe", 5);
            Produit frites = new Produit(5, "Frites", 20);

            List<Produit> listeProduits1 = new List<Produit>() { pizza, tiramisu };
            List<Produit> listeProduits2 = new List<Produit>() { crepe, frites };

            Commande commande = serge.PrendreCommande(damien, listeProduits1);
            patrick.PrendreCommande(jeanne, listeProduits2);

            List<Serveur> listeServeurs = new List<Serveur>() { serge, patrick };

            Restaurant leResto = new Restaurant("LeResto", listeServeurs);

            // On vérifie que le chiffre d'affaires du serveur correspond bien à la somme des prix des produits commandés
            Assert.Equal(pizza.Prix + tiramisu.Prix, serge.ChiffreAffaires);

            Assert.Equal(commande.LeClient, damien);
            Assert.Equal(commande.LeServeur, serge);
            Assert.Equal(commande.LesProduits, listeProduits1);

            // On vérifie que la somme des chiffres d'affaires des serveurs est égale au chiffre d'affaire du Restaurant
            Assert.Equal(serge.ChiffreAffaires + patrick.ChiffreAffaires, leResto.ChiffreAffaires);
        }

    }
}
;