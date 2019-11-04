using System;
using PizzaBox.Domain.Interfaces;

namespace PizzaBox.Domain.Abstracts
{
  public abstract class AAccount : IAccount
  {
    public string UserName { get; set; }
    public string Password { get; set; }

    public void Login()
    {
      Console.WriteLine("Input UserName");
      UserName = Console.ReadLine();
      Console.WriteLine("Input Password");
      Password = Console.ReadLine();
      
    }
  }
}