using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts
{
  public abstract class APizza : IPizza

  {
    public bool AddTopping()
    {
      throw new System.NotImplementedException();
    }

    public double CalculateCost()
    {
      throw new System.NotImplementedException();
    }

    public string ChooseCrust()
    {
      throw new System.NotImplementedException();
    }

    public int ChooseSize()
    {
      throw new System.NotImplementedException();
    }

    public bool RemoveTopping()
    {
      throw new System.NotImplementedException();
    }

    public string ToppingToAdd()
    {
      throw new System.NotImplementedException();
    }

    public string ToppingToRemove()
    {
      throw new System.NotImplementedException();
    }
  }
}