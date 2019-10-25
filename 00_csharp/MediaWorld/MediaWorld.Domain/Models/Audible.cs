namespace MediaWorld.Domain.Models 
{
  public class Audible : Music 
  {
    public string Speaker { get; set; }

    public Audible() 
    {
      Speaker = "shel sliverstien";
    }
  }
}