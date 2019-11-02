using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts
{
  public abstract class AOrder : IOrder

  {
    public double ComputeCost()
    {
      throw new System.NotImplementedException();
    }

    public List<Pizza> ViewPizzas()
    {
      throw new System.NotImplementedException();
    }
  }
}