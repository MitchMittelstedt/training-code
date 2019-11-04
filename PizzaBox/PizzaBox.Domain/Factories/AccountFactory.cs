using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Factories

{
  public class AccountFactory
  {
    public T Create<T>(string username, string password) where T : AAccount, new()
    {
      
      T account = new T();
      account.UserName = username;
      account.Password = password;
      return new T();
    }
  }

}