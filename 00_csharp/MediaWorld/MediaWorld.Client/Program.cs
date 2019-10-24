using System;

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
        }
    }
}
