using System;
using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Abstracts
{
  public abstract class AUser : AAccount

  {

    public User CreateUser()
    {
      throw new NotImplementedException();
    }

    public abstract Order MakeOrder(Location location);

    public void ViewOrderHistory()
    {
      
    }
  }
}