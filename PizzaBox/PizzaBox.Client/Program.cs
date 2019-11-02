using System;
using PizzaBox.Storing.Repositories;

namespace PizzaBox.Client
{
    internal class Program
    {
      private static UserRepository _userRepository = new UserRepository();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
