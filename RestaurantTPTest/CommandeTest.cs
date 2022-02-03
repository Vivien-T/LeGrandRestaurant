using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantTPTest.utilities;
using RestaurantTP;
using Xunit;

namespace RestaurantTPTest
{
    public class CommandeTest
    {

        private Client _client = new Client("FLorent");
        private Serveur _serveur = new Serveur("Theo");


        [Fact]
        public void AjoutUnProduit()
        {
            var commandeTest = new CommandeBuilder().Commandé(_client, _serveur).Build();
            Produit lasagnes = new Produit(100,"Lasagnes", 6);
            commandeTest.AjouterUnProduit(lasagnes);
            List<Produit> lesPropro = new List<Produit>() { lasagnes };
            Assert.Equal(lesPropro, commandeTest.LesProduits);
        }

        [Fact]
        public void AjoutDesProduit()
        {
            var commandeTest = new CommandeBuilder().Commandé(_client, _serveur).Build();
            Produit lasagnes = new Produit(100, "Lasagnes", 6);
            Produit tartes = new Produit(100, "tartes", 35);
            Produit spaghettis = new Produit(23, "spaghettis", 100);
            Produit salade = new Produit(60, "salade", 10);
            List<Produit> lesPropro = new List<Produit>() { lasagnes, tartes, spaghettis, salade };
            commandeTest.AjouterDesProduits(lesPropro);
            Assert.Equal(lesPropro, commandeTest.LesProduits);
        }

        [Fact]
        public void AjoutUnPuisDesProduit()
        {
            var commandeTest = new CommandeBuilder().Commandé(_client, _serveur).Build();
            Produit lasagnes = new Produit(100, "Lasagnes", 6);
            Produit tartes = new Produit(100, "tartes", 35);
            Produit spaghettis = new Produit(23, "spaghettis", 100);
            Produit salade = new Produit(60, "salade", 10);
            List<Produit> lesPropro = new List<Produit>() { tartes, spaghettis, salade };
            commandeTest.AjouterUnProduit(lasagnes);
            commandeTest.AjouterDesProduits(lesPropro);
            List<Produit> produitsFinaux = new List<Produit>() { lasagnes, tartes, spaghettis, salade };
            Assert.Equal(produitsFinaux, commandeTest.LesProduits);
        }

        [Fact]
        public void EnleverUnProduit()
        {
            //TODO
            var commandeTest = new CommandeBuilder().Commandé(_client, _serveur).Build();
            Produit lasagnes = new Produit(100, "Lasagnes", 6);
            Produit tartes = new Produit(100, "tartes", 35);
            Produit spaghettis = new Produit(23, "spaghettis", 100);
            Produit salade = new Produit(60, "salade", 10);
            List<Produit> lesPropro = new List<Produit>() { lasagnes, tartes, spaghettis, salade };
            commandeTest.AjouterDesProduits(lesPropro);
            Assert.Equal(lesPropro, commandeTest.LesProduits);
        }

        [Fact]
        public void EnleverDesProduits()
        {
            //TODO
            var commandeTest = new CommandeBuilder().Commandé(_client, _serveur).Build();
            Produit lasagnes = new Produit(100, "Lasagnes", 6);
            Produit tartes = new Produit(100, "tartes", 35);
            Produit spaghettis = new Produit(23, "spaghettis", 100);
            Produit salade = new Produit(60, "salade", 10);
            List<Produit> lesPropro = new List<Produit>() { lasagnes, tartes, spaghettis, salade };
            commandeTest.AjouterDesProduits(lesPropro);
            Assert.Equal(lesPropro, commandeTest.LesProduits);
        }

        [Fact]
        public void SommeDesProduits()
        {
            //TODO
            var commandeTest = new CommandeBuilder().Commandé(_client, _serveur).Build();
            Produit lasagnes = new Produit(100, "Lasagnes", 6);
            Produit tartes = new Produit(100, "tartes", 35);
            Produit spaghettis = new Produit(23, "spaghettis", 100);
            Produit salade = new Produit(60, "salade", 10);
            List<Produit> lesPropro = new List<Produit>() { lasagnes, tartes, spaghettis, salade };
            commandeTest.AjouterDesProduits(lesPropro);
            Assert.Equal(lesPropro, commandeTest.LesProduits);
        }

    }
}
