using System;
using MediaWorld.Domain.Models;
using MediaWorld.Domain.Singletons;
using MediaWorld.Domain.Abstracts;
using MediaWorld.Domain.Factories;
using MediaWorld.Storing.Repositories;
using Serilog;
using System.Threading;
using System.Threading.Tasks;

namespace MediaWorld.Client
{
  /// <summary>
  /// contains the starting method
  /// </summary>
    internal class Program
    {
      private static MediaRepository _repository = new MediaRepository();
      
      /// <summary>
      /// starts the application
      /// </summary>
        private static void Main()
        {
          (new Program()).ApplicationStart();
          Play();
          // MagicThread();
          // await MagicAsync();
          // Console.WriteLine("end of code");
          // Thread.Sleep(1000);
          // Log.Warning("end of Main Method");
        }

        private void ApplicationStart()
        {
          Log.Logger = new LoggerConfiguration().MinimumLevel.Debug().WriteTo.Console().WriteTo.File("log.txt").CreateLogger();
        }
        private static void Play() 
        {
          Log.Information("Play Method");
          // MediaSingleton mediaPlayer = MediaSingleton.GetInstance();
          // Music song = new Song();
          // Music audible = new Audible();

          // mediaPlayer.Play(song);
          // mediaPlayer.Play(audible);

          var mediaPlayer = MediaSingleton.Instance; //MediaSingleton.Instance;
          // var audioFactory = new AudioFactory();
          // var videoFactory = new VideoFactory();
          // AMedia song = audioFactory.Create<Song>();
          // AMedia movie = videoFactory.Create<Movie>();
          foreach(var item in _repository.MediaLibrary)
          {
            Log.Debug("{@item}", item);
            Log.Debug("{one}", item.Title);
            mediaPlayer.Execute(item.Play, item);
          }





          // mediaPlayer.Execute("play", song);
          // mediaPlayer.Execute("play", movie);
        }

        private static void MagicThread()
        {
          var t1 = new Thread(() => { Run("A"); });
          var t2 = new Thread(() => { Run("B"); });

          t2.Start();
          t1.Start();
          t1.Join();
          t2.Join();

          // if(t1.IsAlive)
          // {
          //   t1.Abort();
          // }
        }

        private static void MagicTasks()
        {
          var t1 = new Task(() => { Run("A"); });
          var t2 = new Task(() => { Run("B"); });

          t1.Start();
          t2.Start();

          Task.WaitAll(new Task[] {t1, t2}, 1000);
        }

        private static async Task MagicAsync()
        {
          await Task.Run(() => { Run("C"); });
          await Task.Run(() => { Run("D"); });
        } 

        private static void Run(string s)
        {
            for (var x = 0; x < 1000; x += 1) 
            {
              Console.Write(s);
            }
        }
    }
}
