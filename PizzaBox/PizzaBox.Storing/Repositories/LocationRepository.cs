using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Factories;

namespace PizzaBox.Storing.Repositories
{
  public class LocationRepository
  {
    private List<Location> _locationLibrary;
    public List<Location> LocationLibrary
    {
      get
      {
        return _locationLibrary;
      }
    }
    public LocationRepository()
    {
      Initialize();
    }
    private List<Location> Initialize()
    {
      var accountFactory = new AccountFactory();
      if(_locationLibrary == null)
      {
        _locationLibrary = new List<Location>();
        Location location1 = accountFactory.Create<Location>("PizzaHat", "password");
        _locationLibrary.Add(location1);
      }

      return _locationLibrary;
    }
  }
}