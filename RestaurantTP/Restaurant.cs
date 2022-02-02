using System.Collections.Generic;
using System.Linq;

namespace RestaurantTP
{
    public class Restaurant
    {
        private readonly List<Serveur> _serveurs;
        public string Nom { get; private set; }

        public Restaurant(string nom, List<Serveur> serveurs)
        {
            _serveurs = serveurs;
            Nom = nom;
        }

        public float ChiffreAffaires
            => _serveurs.Sum(serveur => serveur.ChiffreAffaires);
    }
}
