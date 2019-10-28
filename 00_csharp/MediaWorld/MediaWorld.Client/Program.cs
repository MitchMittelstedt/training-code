using System;
using MediaWorld.Domain.Models;
using MediaWorld.Domain.Singletons;
using MediaWorld.Domain.Abstracts;

namespace MediaWorld.Client
{
  /// <summary>
  /// contains the starting method
  /// </summary>
    internal class Program
    {
      /// <summary>
      /// starts the application
      /// </summary>
        private static void Main()
        {
          Play();
        }
        private static void Play() 
        {
          // MediaSingleton mediaPlayer = MediaSingleton.GetInstance();
          // Music song = new Song();
          // Music audible = new Audible();

          // mediaPlayer.Play(song);
          // mediaPlayer.Play(audible);

          var mediaPlayer = MediaSingleton.Instance; //MediaSingleton.Instance;
          AMedia song = new Song();
          AMedia movie = new Movie();

          mediaPlayer.Execute("play", song);
          mediaPlayer.Execute("play", movie);
        }
    }
}
