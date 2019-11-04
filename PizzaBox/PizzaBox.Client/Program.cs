﻿using System;
using PizzaBox.Client.Singletons;
using PizzaBox.Domain.Factories;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Repositories;

namespace PizzaBox.Client
{
    internal class Program
    {
      private static UserRepository _userLibrary = new UserRepository();
      private static LocationRepository _locationLibrary = new LocationRepository();        
      private static OrderRepository _orderLibrary = new OrderRepository();
      
      static void Main()
        {
          Start();
        }

        private static void Start()
        {
          var menu = MenuSingleton.Instance;
          Console.WriteLine("Are you 1) a customer or 2) a employee?");
          var input = int.Parse(Console.ReadLine());
          if(input == 1) 
          {
            var accountFactory = new AccountFactory();
            var user = accountFactory.Create<User>("Mitch", "password");
            _userLibrary.UserLibrary.Add(user);
            user.Login();
            foreach(var item in _userLibrary.UserLibrary)
            {
              if(item.UserName == user.UserName && item.Password == user.Password)
              {
                user.order = user.MakeOrder();
                _orderLibrary.OrderLibrary.Add(user.order);
              }
              else
              {
                Console.WriteLine("Invalid login");
                Start();
              }
            }
            
            

          }
          else if(input == 2)
          {
            var accountFactory = new AccountFactory();
            var location = accountFactory.Create<Location>("PizzaHat", "password");
            location.Login();
            foreach(var item in _locationLibrary.LocationLibrary)
            {
              if(item.UserName == location.UserName && item.Password == location.Password)
              {

              }
            }
          }

          foreach(var item in _userLibrary.UserLibrary)
          {
            
          }
        }
    }
}
