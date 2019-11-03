using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts
{
  public abstract class APizza

  {
    public string Crust;
    public int Size;    
    public List<string> Toppings;
    public double Cost;
  }
}