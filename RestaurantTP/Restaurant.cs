using System.Linq;

namespace RestaurantTP
{
    public class Restaurant
    {
        private readonly Serveur[] _serveurs;
        public string Nom { get; private set; }

        public Restaurant(string nom, Serveur[] serveurs)
        {
            _serveurs = serveurs;
            Nom = nom;
        }

        public float ChiffreAffaires
            => _serveurs.Sum(serveur => serveur.ChiffreAffaires);
    }
}
