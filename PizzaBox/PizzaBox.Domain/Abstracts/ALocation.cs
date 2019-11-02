using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts
{
  public abstract class ALocation : ILocation
  {
    public List<Order> ViewCompletedOrders()
    {
      throw new System.NotImplementedException();
    }

    public List<User> ViewUsers()
    {
      throw new System.NotImplementedException();
    }
  }
}