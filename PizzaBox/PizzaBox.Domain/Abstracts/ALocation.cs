using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts
{
  public abstract class ALocation : AAccount
  {
    Location location;
    public List<Order> ViewCompletedOrders()
    {
      throw new System.NotImplementedException();
    }

    public List<User> ViewUsers()
    {
      throw new System.NotImplementedException();
    }

    public List<Pizza> MakePizza(Order order)
    {
      List<Pizza> listOfPizzas = new List<Pizza>();

      return listOfPizzas;
    }
  }
}