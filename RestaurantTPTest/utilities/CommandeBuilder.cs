using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantTP;

namespace RestaurantTPTest.utilities
{
    internal class CommandeBuilder
    {
        private Client _client;
        private Serveur _serveur;

        public CommandeBuilder Commandé(Client client, Serveur serveur)
        {
            _client = client;
            _serveur = serveur;
            return this;
        }

        public Commande Build()
        {
            return new Commande(_serveur, _client);
        }
    }
}
