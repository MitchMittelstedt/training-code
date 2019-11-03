using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Factories

{
  public class LocationFactory
  {
    public ALocation Create<T>() where T : ALocation, new()
    {
      return new T();
    }
  }

}