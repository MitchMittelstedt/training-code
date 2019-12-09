using MediaWorld.Domain.Abstracts;
using MediaWorld.Domain.Factories;
using MediaWorld.Domain.Models;
using MediaWorld.Domain.Singletons;
using Moq;
using Xunit;

namespace MediaWorld.Testing.Specs

{
  public class MediaSpec
  {
    AudioFactory af = new AudioFactory();
    VideoFactory vf = new VideoFactory();

    [Fact]
    public void Test_AudioObject()
    {
      //arrrange
      var sut = af;
      var expected = typeof(Song);

      //act
      var actual = af.Create<Song>();
      
      //assert
      Assert.True(expected == actual.GetType());
    }

    Mock<AMedia> mock;

    public MediaSpec() 
    {
      mock = new Mock<AMedia>();
      mock.Setup(am => am.Play()).Returns(false);
    }

    [Fact]
    public void Test_VideoObject()
    {
      //arrange
      var sut = vf;
      var expected = typeof(Movie);

      //act
      var actual = af.Create<Movie>();

      //asert
      Assert.True(expected == actual.GetType());
    }

    [Fact]
    public void Test_VideoPlay()
    {
      var sut = MediaSingleton.Instance; //vf.Create<Movie>(); //subject of test
      var mm = mock.Object;

      mm.Duration = new System.TimeSpan(1,0,0);

      Assert.True(sut.Execute(mm.Play, mm));
    }
  }
}