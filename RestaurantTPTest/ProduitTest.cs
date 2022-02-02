using System.Linq;
using RestaurantTPTest.utilities;
using Xunit;

namespace RestaurantTPTest
{
    public class ProduitTest
    {
        [Fact]
        public void Produit_bien_créé_avec_statut_non_pret()
        {
            var produit = new ProduitBuilder().Créé(10, "Produit", 100).Build();

            Assert.Equal(10, produit.Prix);
            Assert.Equal("Produit", produit.Nom);
            Assert.Equal(100, produit.Stock);
            Assert.Equal("non prêt", produit.Statut);
        }

        [Fact]
        public void Produits_bien_créés_avec_statut_non_pret()
        {
            var desProduits = new ProduitGenerator().Créés(10, "Produit", 100).Generate(250);

            Assert.Equal(2500, desProduits.Sum(produit => produit.Prix));
            Assert.Equal(25000, desProduits.Sum(produit => produit.Stock));
        }
    }
}
