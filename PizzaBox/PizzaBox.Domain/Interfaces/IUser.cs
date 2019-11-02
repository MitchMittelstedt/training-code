namespace PizzaBox.Domain.Interfaces
{
  public interface IUser
  {
    User CreateUser();
    List<Order> ViewOrderHistory();
    Pizza OrderPizza();
  }
}