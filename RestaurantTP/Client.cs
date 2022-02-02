using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantTP
{
    public class Client
    {
        public String Nom { get; private set; }

        public Client(string nom)
        {
            Nom = nom;
        }
    }
}
