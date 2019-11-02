using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Interfaces
{
  public interface ILocation
  {
    List<Order> ViewCompletedOrders();
    List<User> ViewUsers();
  }
}