using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Repositories
{
  public class UserRepository
  {
    private List<AUser> _userLibrary;
    public List<AUser> UserLibrary
    {
      get
      {
        return _userLibrary;
      }
    }
    public UserRepository()
    {
      Initialize();
    }
    private List<AUser> Initialize()
    {
      if(_userLibrary == null)
      {
        _userLibrary = new List<AUser>();
      }

      return _userLibrary;
    }


  }
}