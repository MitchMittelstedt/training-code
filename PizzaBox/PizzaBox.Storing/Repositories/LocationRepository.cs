using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Factories;

namespace PizzaBox.Storing.Repositories
{
  public class LocationRepository
  {
    private List<ALocation> _locationLibrary;
    public List<ALocation> LocationLibrary
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
    private List<ALocation> Initialize()
    {
      var locationFactory = new AccountFactory();
      if(_locationLibrary == null)
      {
        _locationLibrary = new List<ALocation>();
      }

      return _locationLibrary;
    }
  }
}