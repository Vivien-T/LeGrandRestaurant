using System.Collections.Generic;
using RestaurantTP;

namespace RestaurantTPTest.utilities
{
    internal class ServeurGenerator
    {
        private ServeurBuilder _builder = new ServeurBuilder();

        public ServeurGenerator Nommés(string nom)
        {
            _builder = _builder.Nommé(nom);
            return this;
        }

        public IEnumerable<Serveur> Generate(int howMany)
        {
            for (var i = 0; i < howMany; i++)
            {
                yield return _builder.Build();
            }
        }
    }
}
