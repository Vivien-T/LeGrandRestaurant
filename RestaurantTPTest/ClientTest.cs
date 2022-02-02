using System.Linq;
using RestaurantTPTest.utilities;
using Xunit;

namespace RestaurantTPTest
{
    public class ClientTest
    {
        [Fact]
        public void Client_n_a_rien_a_payer()
        {
            var damien = new ClientBuilder().Nommé("Damien").Build();

            Assert.Equal(0, damien.montantAPayer);
        }

        [Fact]
        public void Beaucoup_de_client_n_ont_rien_a_payer()
        {
            var desClients = new ClientGenerator().Nommés("Damien").Generate(250);

            Assert.Equal(0, desClients.Sum(roger => roger.montantAPayer));
        }

        [Fact]
        public void un_client_a_beaucoup_a_payer()
        {
            var damien = new ClientBuilder().Nommé("Damien").Build();

            damien.Commander(4500);

            Assert.Equal(4500, damien.montantAPayer);
        }

        [Fact]
        public void une_armee_a_beaucoup_a_payer()
        {
            var desClients = new ClientGenerator().Nommés("Damien").Generate(100);

            desClients.All(damien => damien.Commander(4500));

            Assert.Equal(450000, desClients.Sum(damien => damien.montantAPayer));
        }
    }
}
