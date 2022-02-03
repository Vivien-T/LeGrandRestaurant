using RestaurantTP;
using System.Collections.Generic;

namespace RestaurantTPTest.utilities
{
  internal class FranchiseBuilder
  {
    private string _nom = string.Empty;
    private List<Restaurant> _listResto = new List<Restaurant>() ;

    public FranchiseBuilder Créé( string nom , List<Restaurant> listResto)
    {
      _nom = nom;
      _listResto = listResto;

      return this;
    }

    public Franchise Build()
    {
      return new Franchise( _nom , _listResto);
    }
  }
}
