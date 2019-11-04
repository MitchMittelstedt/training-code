using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Factories;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Repositories
{
  public class UserRepository
  {
    private List<User> _userLibrary;
    public List<User> UserLibrary
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
    private void Initialize()
    {

      var accountFactory = new AccountFactory();
      if(_userLibrary == null)
      {
        _userLibrary = new List<User>();
        User user1 = accountFactory.Create<User>("Mitch", "password");
        _userLibrary.Add(user1);
        
      }
    }


  }
}