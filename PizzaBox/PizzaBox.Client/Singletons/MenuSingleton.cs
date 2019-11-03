namespace PizzaBox.Client.Singletons
{
  public class MenuSingleton
  {
    private static readonly MenuSingleton _instance = new MenuSingleton();

    public static MenuSingleton Instance
    {
      get
      {
        return _instance;
      }
    }

    private MenuSingleton() {}
  }
}