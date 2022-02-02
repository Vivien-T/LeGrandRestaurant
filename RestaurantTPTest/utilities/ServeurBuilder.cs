using System;
using System.Collections.Generic;
using System.Text;
using RestaurantTP;

namespace RestaurantTPTest.utilities
{
    internal class ServeurBuilder
    {
        private string _nom = string.Empty;

        public ServeurBuilder Nommé(string nom)
        {
            _nom = nom;
            return this;
        }

        public Serveur Build()
        {
            return new Serveur(_nom);
        }
    }
}
