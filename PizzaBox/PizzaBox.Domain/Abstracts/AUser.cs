using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts
{
  public abstract class AUser : IUser

  {

    public User CreateUser()
    {
      throw new System.NotImplementedException();
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