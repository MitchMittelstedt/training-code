using MediaWorld.Domain.Abstracts;
using MediaWorld.Domain.Interfaces;
using MediaWorld.Domain.Models;

namespace MediaWorld.Domain.Factories 
{
  public class VideoFactory : IFactory
  {
    /// <summary>
    /// type must come from AMedia, must have empty contructor
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public AMedia Create<T>() where T : AMedia, new()
    { 
      return new T();
      // switch (type)
      // {
      //   case "book":
      //     return new Book();
      //   case "song":
      //     return new Song();
      //   default:
      //     return null;
      // }

    }
  }
}