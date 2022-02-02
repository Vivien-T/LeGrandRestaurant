using System.Linq;
using RestaurantTPTest.utilities;
using Xunit;

namespace RestaurantTPTest
{
    public class ProduitTest
    {
        [Fact]
        public void Statut_d_un_produit_non_pret()
        {
            var produit = new ProduitBuilder().Créé(10, "Produit", 10).Build();

            Assert.Equal("non prêt", produit.Statut);
        }

        [Fact]
        public void Statut_de_plusieurs_produits_non_pret()
        {
            var desProduits = new ProduitGenerator().Créés(10, "Produit", 10).Generate(250);

            Assert.Equal("non prêt", desProduits.Sum(produit => produit.Statut));
        }
    }
}
