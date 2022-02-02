using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantTP;

namespace RestaurantTPTest.utilities
{
    class CommandeGenerator
    {
        private CommandeBuilder _builder = new CommandeBuilder();

        public CommandeGenerator Commandés(Serveur serveur, Client client)
        {
            _builder = _builder.Commandé(client, serveur);
            return this;
        }

        public IEnumerable<Commande> Generate(int howMany)
        {
            for (var i = 0; i < howMany; i++)
            {
                yield return _builder.Build();
            }
        }
    }
}
