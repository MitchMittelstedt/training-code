using System;
using MediaWorld.Domain.Abstracts;
using MediaWorld.Domain.Interfaces;
using static MediaWorld.Domain.Delegates.ControlDelegate;

namespace MediaWorld.Domain.Singletons
{
    public class MediaSingleton : IPlayer
    {
      private static readonly MediaSingleton _instance = new MediaSingleton(); 

      public static MediaSingleton Instance 
      {
        get 
        {
          return _instance;
        }
      }

      private  MediaSingleton() {}

      public bool Execute(ButtonDelegate button, AMedia media) 
      {
        media.ResultEvent += ResultHandler;
        button();
        return true;
      }

      public void ResultHandler(AMedia media)
      {
        Console.WriteLine("{0} is playing...", media.Title);
      }

    public bool VolumeUp()
    {
      return true;
    }

    public bool VolumeDown()
    {
      throw new NotImplementedException();
    }

    public bool VolumeMute()
    {
      throw new NotImplementedException();
    }

    public bool PowerUp()
    {
      throw new NotImplementedException();
    }

    public bool PowerDown()
    {
      throw new NotImplementedException();
    }
  }
}
