namespace MediaWorld.Domain.Abstracts 
{
  public abstract class AVideo : AMedia 
  {
    public int FrameRate { get; set; }

    public override bool Forward() 
    {
      return true;
    }

    public override bool Rewind()
    {
      return true;
    }

    public new bool Stop()
    {
      return true;
  
    }

    public override string ToString()
    {
      return $"{Title} {Duration} \nFramerate: {FrameRate}";
    }
  }
}