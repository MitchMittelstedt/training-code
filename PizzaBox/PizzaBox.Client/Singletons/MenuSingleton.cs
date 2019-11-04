using System;
using System.Collections.Generic;
using PizzaBox.Domain.Factories;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Repositories;

namespace PizzaBox.Client.Singletons
{
  public class MenuSingleton
  {
    private static UserRepository _userLibrary = new UserRepository();
    private static LocationRepository _locationLibrary = new LocationRepository(); 
    private static OrderRepository _orderLibrary = new OrderRepository(); 
    private static readonly MenuSingleton _instance = new MenuSingleton();

    public static MenuSingleton Instance
    {
      get
      {
        return _instance;
      }
    }

    private MenuSingleton() {}

    public void Start()
    {
      AccountLogin();
    }

    public void AccountLogin()
    {
      // var accountFactory = new AccountFactory();

      // var location = accountFactory.Create<Location>("PizzaHat", "password");
      // _locationLibrary.LocationLibrary.Add(location);

      Console.WriteLine("Are you 1) a customer or 2) a employee?");
      var input = int.Parse(Console.ReadLine());
      
      if(input == 1) 
      {
        var user = UserLogin();
        var location = ChooseLocation();
        var order = user.MakeOrder(location);

      }

      else if(input == 2)
      {
        
        // location.Login();
        // foreach(var item in _locationLibrary.LocationLibrary)
        // {
        //   if(item.UserName == location.UserName && item.Password == location.Password)
        //   {
            
        //   }
        // }
      }
    }

    public User UserLogin()
    {
      User user = new User();
      Console.WriteLine("Please enter UserName");
      var userName = Console.ReadLine();
      Console.WriteLine("Please enter Password");
      var password = Console.ReadLine();

      foreach(var item in _userLibrary.UserLibrary)
      {
        Console.WriteLine(userName + " vs " + item.UserName);
        Console.WriteLine("above");
        Console.WriteLine(item.UserName);
        Console.WriteLine("below");
        if(userName == item.UserName && password == item.Password)
        {
          user = item;
        }
        else
        {
          Console.WriteLine("Nope.");
          AccountLogin();
        }
      }
      return user;
    }

    public Location ChooseLocation()
    { 
      string text = "";
      foreach(var item in _locationLibrary.LocationLibrary)
      {
        Console.WriteLine("A");
        text = string.Join(", ", item.UserName);
      }
      Console.WriteLine($"Please choose among the following locations: {text}");
      
      string location = Console.ReadLine();
      var storeLocation = new Location();
      foreach(var item in _locationLibrary.LocationLibrary)
      {
        if(location == item.UserName)
        {
          storeLocation = item;
          Console.WriteLine($"You choose {item.UserName}");
        }
        else
        {
          Console.WriteLine("Invalid location name. Try again.");
          ChooseLocation();
        }
      }
      return storeLocation;
    }

    public void UserOrEmployee()
    {
      Console.WriteLine("Are you a 1) user or 2) employee?");
      var input = int.Parse(Console.ReadLine());
      if(input == 1)
      {
        UserLogin();
      }
      else if(input == 2)
      {

      }
    }
  }
}