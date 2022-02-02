using System.Collections.Generic;
using RestaurantTP;

namespace RestaurantTPTest.utilities
{
    internal class ProduitGenerator
    {
        private ProduitBuilder _builder = new ProduitBuilder();

        public ProduitGenerator Créés(float prix, string nom, int stock)
        {
            _builder = _builder.Créé(prix, nom, stock);
            return this;
        }

        public IEnumerable<Produit> Generate(int howMany)
        {
            for (var i = 0; i < howMany; i++)
            {
                yield return _builder.Build();
            }
        }
    }
}
