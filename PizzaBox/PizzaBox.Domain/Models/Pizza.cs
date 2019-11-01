using System;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Pizza
  {
    List<string> Toppings;
    string Crust;
    int Size;
    double Cost;
    public Pizza()
    {
      Toppings.Add("cheese", "sauce");
      Crust = "thin";
      Size = 12;
      Cost = 10.00;
    }

    private void Initialize()
    {

    }
  }
}