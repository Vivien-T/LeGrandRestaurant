using System;
using System.Collections.Generic;
using System.Text;
using RestaurantTP;
namespace RestaurantTPTest.utilities
{
    class CuisineBuilder
    {
        private Restaurant _resto;

        public CuisineBuilder  Creer(string name)
        {
            List<Serveur> list = new List<Serveur>();
            _resto = new Restaurant(name, list);
            return this;
        }
        public Cuisine Build()
        {
            return new Cuisine(_resto);
        }
    }
}
