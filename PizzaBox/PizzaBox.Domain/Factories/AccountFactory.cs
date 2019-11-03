using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Factories

{
  public class AccountFactory : IFactory
  {
    public AUser CreateUser<T>() where T : AUser, new()
    {
      return new T();
    }
  }

}