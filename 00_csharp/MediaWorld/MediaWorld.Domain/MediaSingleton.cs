using System;

namespace MediaWorld.Domain.Models
{
    public class MediaSingleton
    {
      private static readonly MediaSingleton _instance = new MediaSingleton(); 
      
      private  MediaSingleton() {}

      public static MediaSingleton GetInstance() 
      {
        return _instance;
      }
    }
}
