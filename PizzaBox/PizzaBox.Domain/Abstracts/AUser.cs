using System;
using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts
{
  public abstract class AUser : IUser

  {
    string username;
    string password;
    string address;

    /// <summary>
    /// acquires user information
    /// </summary>

    public User CreateUser()
    {
      User user = new User();
      Console.WriteLine("Welcome, please create an account.");
      Console.WriteLine("Username:");
      user.username = Console.ReadLine();
      Console.WriteLine("Password:");
      user.password = Console.ReadLine();
      Console.WriteLine("Address");
      user.address = Console.ReadLine();
      return user;
    }

    public Pizza OrderPizza()
    {
      throw new System.NotImplementedException();
    }

    public List<Order> ViewOrderHistory()
    {
      throw new System.NotImplementedException();
    }
  }
}