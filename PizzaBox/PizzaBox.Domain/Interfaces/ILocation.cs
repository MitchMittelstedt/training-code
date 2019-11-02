namespace MediaWorld.Domain.Interfaces
{
  public interface ILocation
  {
    List<Order> ViewCompletedOrders();
    List<User> ViewUsers();
    List<Sale> ViewSales();
    List<Inventory> ViewInventory();
  }
}