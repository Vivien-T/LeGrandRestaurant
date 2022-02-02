using System.Linq;

namespace RestaurantTP
{
    public class Restaurant
    {
        private readonly Serveur[] _serveurs;
        public string Nom { get; private set; }

        public Restaurant(string nom, params Serveur[] serveurs)
        {
            _serveurs = serveurs;
            Nom = nom;
        }

        public decimal ChiffreAffaires
            => _serveurs.Sum(serveur => serveur.ChiffreAffaires);
    }
}
