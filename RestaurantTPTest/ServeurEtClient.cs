using System.Linq;
using RestaurantTPTest.utilities;
using Xunit;

namespace RestaurantTPTest
{
    public class ServeurEtClient
    {
        [Fact]
        public void Client_Passe_Commande_a_un_Serveur()
        {
            var damien = new ClientBuilder().Nommé("Damien").Build();
            var serge = new ServeurBuilder().Nommé("Serge").Build();


            // Assert.Equal(0, damien.montantAPayer);
        }

    }
}
