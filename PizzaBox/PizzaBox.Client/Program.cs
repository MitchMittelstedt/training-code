using System;
using PizzaBox.Client.Singletons;
using PizzaBox.Storing.Repositories;

namespace PizzaBox.Client
{
    internal class Program
    {
      private static UserRepository _userRepository = new UserRepository();
      private static LocationRepository _locationRepository = new LocationRepository();        
      static void Main()
        {
          Start();
        }

        private static void Start()
        {
          var menu = MenuSingleton.Instance;
        }
    }
}
