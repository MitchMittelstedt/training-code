using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Factories

{
  public class AccountFactory
  {
    public AAccount Create<T>() where T : ALocation, new()
    {
      return new T();
    }
  }

}