using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Interfaces
{
  public interface IUser
  {
    User CreateUser();
    List<Order> ViewOrderHistory();
    Pizza OrderPizza();
  }
}