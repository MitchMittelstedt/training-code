using System;
using MediaWorld.Domain.Models;

namespace MediaWorld.Client
{
  /// <summary>
  /// 
  /// </summary>
    internal class Program
    {
      /// <summary>
      /// 
      /// </summary>
        private static void Main()
        {
            var helper = MediaSingleton.GetInstance();
            Console.WriteLine(helper);

            DisplayMusic();
        }
        private static void DisplayMusic() 
        {
          Music m = new Song();
          Console.WriteLine(m.Artist);
        }
    }
}
