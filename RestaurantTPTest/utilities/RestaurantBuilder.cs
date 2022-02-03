using RestaurantTP;
using System.Collections.Generic;

namespace RestaurantTPTest.utilities
{
  internal class RestaurantBuilder
  {
    private List<Serveur> _serveurs = new List<Serveur>();
    private string _nom { get; set; }

    public RestaurantBuilder Créé(List<Serveur> serveurs, string nom)
    {
      _nom = nom;
      _serveurs = serveurs;

      return this;
    }

    public Restaurant Build()
    {
      return new Restaurant(_nom, _serveurs);
    }
  }
}
