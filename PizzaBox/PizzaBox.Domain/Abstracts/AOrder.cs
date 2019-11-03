using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts
{
  public abstract class AOrder

  {
    public List<Pizza> OrderedPizzas;
    public double Cost;

  }
}