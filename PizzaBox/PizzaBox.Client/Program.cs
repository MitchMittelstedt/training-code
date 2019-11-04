using System;
using PizzaBox.Client.Singletons;
using PizzaBox.Domain.Factories;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Repositories;

namespace PizzaBox.Client
{
    internal class Program
    {
      
      static void Main()
        {
          Start();
        }

        private static void Start()
        {
          var menu = MenuSingleton.Instance;
          menu.Start();
        }
    }
}
