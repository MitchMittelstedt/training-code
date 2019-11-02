namespace PizzaBox.Domain.Interfaces
{
  public interface IPizza
  {  
    string ChooseCrust();
    bool AddTopping();
    string ToppingToAdd();
    bool RemoveTopping();
    string ToppingToRemove();
    int ChooseSize();
    double CalculateCost();
  }
}