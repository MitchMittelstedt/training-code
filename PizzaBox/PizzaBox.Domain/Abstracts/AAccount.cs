using PizzaBox.Domain.Interfaces;

namespace PizzaBox.Domain.Abstracts
{
  public abstract class AAccount : IAccount
  {
    string Username;
    string Password;

    public void Login()
    {
      return;
    }
  }
}