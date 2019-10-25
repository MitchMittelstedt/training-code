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
          Play();
        }
        private static void Play() 
        {
          MediaSingleton mediaPlayer = MediaSingleton.GetInstance();
          Music song = new Song();
          Music audible = new Audible();

          mediaPlayer.Play(song);
          mediaPlayer.Play(audible);
        }
    }
}
