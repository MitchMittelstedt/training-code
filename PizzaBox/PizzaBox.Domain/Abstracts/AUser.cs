using System;
using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Abstracts
{
  public abstract class AUser : AAccount

  {
    User user;
    public User CreateUser()
    {
      throw new NotImplementedException();
    }

    public Pizza OrderPizza()
    {
      throw new NotImplementedException();
    }

    public List<Order> ViewOrderHistory()
    {
      throw new NotImplementedException();
    }
  }
}