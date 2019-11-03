using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Interfaces
{
  public interface IFactory
  {
    AUser CreateUser<T>() where T : AUser, new();
  }
}