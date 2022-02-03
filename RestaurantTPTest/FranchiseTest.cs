using RestaurantTP;
using RestaurantTPTest.utilities;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace RestaurantTPTest
{
    public class FranchiseTest
    {
        [Fact]
        public void Franchise_est_bien_créé()
        {
            var resto1 = new RestaurantBuilder().Créé(new List<Serveur>(){new Serveur("Jean castex") , new Serveur("Jean Belmondo") } , "Mcdonald montpo").Build();
            var resto2 = new RestaurantBuilder().Créé(new List<Serveur>(){new Serveur("Pierre cailloux") , new Serveur("Laviv duchene")} , "Mcdonald montpo").Build();

            var listeResto = new List<Restaurant>(){resto1 , resto2}; 

            var franchise = new FranchiseBuilder().Créé("Mc donold", listeResto).Build();

            Assert.Equal("Mc donold", franchise.Nom);
            Assert.Equal(listeResto, franchise.ListeResto);
        }
    }
}
