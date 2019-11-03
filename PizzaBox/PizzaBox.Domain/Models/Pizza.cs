using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Pizza : APizza
  {


    public Pizza()
    {
      Toppings = new List<string> {"cheese", "sauce"};
      Crust = "thin";
      Size = 12;
      Cost = 10.00;
    }
  }
}