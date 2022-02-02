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
        private string _nom = string.Empty;

        public CommandeBuilder Nommé(string nom)
        {
            _nom = nom;
            return this;
        }

        public Commande Build()
        {
            return new Commande(_nom);
        }
    }
}
