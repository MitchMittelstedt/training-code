using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Factories;
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

      var accountFactory = new AccountFactory();
      if(_userLibrary == null)
      {
        _userLibrary = new List<AUser>();
        User user1 = accountFactory.Create<User>("Mitch", "password");
        Location location1 = accountFactory.Create<Location>("PizzaHat", "password");
      }

      return _userLibrary;
    }


  }
}