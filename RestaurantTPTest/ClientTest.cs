using RestaurantTPTest.utilities;
using System.Linq;
using Xunit;

namespace RestaurantTPTest
{
    public class ClientTest
    {
        [Fact]
        public void Client_est_bien_créé()
        {
            var damien = new ClientBuilder().Nommé("Damien").Build();

            Assert.Equal("Damien", damien.Nom);
        }
    }
}
