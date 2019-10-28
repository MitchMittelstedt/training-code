using System;
using MediaWorld.Domain.Abstracts;

namespace MediaWorld.Domain.Singletons
{
    public class MediaSingleton
    {
      private static readonly MediaSingleton _instance = new MediaSingleton(); 
      
      private  MediaSingleton() {}

      public static MediaSingleton Instance 
      {
        get 
        {
          return _instance;
        }
      }

      public void Execute(string command, AMedia media) 
      {
        Console.WriteLine(media);
      }
    }
}
