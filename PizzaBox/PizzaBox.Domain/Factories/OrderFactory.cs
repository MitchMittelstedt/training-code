using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Factories

{
  public class OrderFactory
  {
    public AOrder Create<T>() where T : AOrder, new()
    {
      return new T();
    }
  }

}