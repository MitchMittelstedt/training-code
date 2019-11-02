namespace PizzaBox.Domain.Interfaces
{
  public interface IOrder
  {
    List<Pizza> ViewPizzas();
    double ComputeCost();
  }
}