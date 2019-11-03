using System;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Interfaces;

namespace PizzaBox.Domain.Models

{
  public class User : AAccount
  {

    public Order order = new Order();
    public Pizza pizza = new Pizza();

    public User()
    {
      order.Cost = 0;
      pizza.Cost = 0;
    }

    // public Order MakePresetOrder()
    // {

    // }

    public Order MakeOrder()
    {
      Pizza pizza = new Pizza();
      pizza.Cost = 10;

      WhichCrust(pizza);
      WhatSize(pizza);
      WhichToppings(pizza);
      PizzaToppingsAddCost(pizza);
      AddPizza(order, pizza);
      AddPizzaCostToOrderCost(order, pizza);

      Console.WriteLine("Would you like to add another pizza to your order? Press Y if yes. Press any other key if no.");
      var userInput = Console.ReadLine().ToLower();
      if(userInput == "y")
      {
        MakeOrder();
      }
      return order;
    }

    public void WhichCrust(Pizza pizza) 
    {
      Console.WriteLine("Which kind of crust? Deep dish or thin?");
      var i = int.Parse(Console.ReadLine());
      switch (i)
      {
        case 1:
          Console.WriteLine("You chose deep dish");
          pizza.Crust = "deep dish";
          pizza.Cost += 1.00;
          break;
        case 2:
          Console.WriteLine("You chose thin crust");
          pizza.Crust = "thin crust";
          break;
      }
    }

    public void WhatSize(Pizza pizza)
    {
      Console.WriteLine("What size?");
      pizza.Size = int.Parse(Console.ReadLine());
    }

    public void WhichToppings(Pizza pizza)
    {
      for (int x = 0; x < 5; x++) 
      {
        Console.WriteLine("Which toppings? 1) Pepperoni, 2) mushrooms, 3) peppers, 4) olives, or 5) bison are your choices. Limit 5.");
        var i = int.Parse(Console.ReadLine());
        switch (i)
        {
          case 1:
            Console.WriteLine("You added pepperoni");
            pizza.Toppings.Add("pepperoni");
            break;
          case 2:
            Console.WriteLine("You added mushrooms");
            pizza.Toppings.Add("mushrooms");
            break;
          case 3:
            Console.WriteLine("You added peppers");
            pizza.Toppings.Add("peppers");
            break;
          case 4:
            Console.WriteLine("You added olives");
            pizza.Toppings.Add("olives");
            break;
          case 5:
            Console.WriteLine("You added bison");
            pizza.Toppings.Add("bison");
            break;
        }
      }
    }
    public void PizzaToppingsAddCost(Pizza pizza)
    { 
      foreach(string item in pizza.Toppings) 
      {
        pizza.Cost += .50;
      }
    }

    public void AddPizza(Order order, Pizza pizza)
    {
      order.OrderedPizzas.Add(pizza);
    }

    public void AddPizzaCostToOrderCost(Order order, Pizza pizza)
    {
      order.Cost += pizza.Cost;
    }
  }
}