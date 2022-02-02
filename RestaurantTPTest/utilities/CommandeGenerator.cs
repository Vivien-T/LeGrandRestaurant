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
        private CommandeGenerator _builder = new();

        public CommandeGenerator Nommés(string nom)
        {
            _builder = _builder.Nommé(nom);
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
