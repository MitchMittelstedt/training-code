using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Interfaces
{
  public interface IOrder
  {
    List<Pizza> ViewPizzas();
    double ComputeCost();
  }
}