using RestaurantTP;

namespace RestaurantTPTest.utilities
{
  internal class ProduitBuilder
  {
    private float _prix = 0;
    private string _nom = string.Empty;
    private int _stock = 0;

    public ProduitBuilder Créé(float prix, string nom, int stock)
    {
      _prix = prix;
      _nom = nom;
      _stock = stock;
      return this;
    }

    public Produit Build()
    {
      return new Produit(_prix, _nom, _stock);
    }
  }
}
