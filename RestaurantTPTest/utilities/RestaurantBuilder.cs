using RestaurantTP;

namespace RestaurantTPTest.utilities
{
  internal class RestaurantBuilder
  {
    private readonly List<Serveur> _serveurs;
    public string Nom { get; private set; }

    public RestaurantBuilder Créé(List<Serveur> serveurs, string nom)
    {
      _nom = nom;
      _serveurs = serveurs;

      return this;
    }

    public Restaurant Build()
    {
      return new Restaurant( _serveurs , _nom);
    }
  }
}
