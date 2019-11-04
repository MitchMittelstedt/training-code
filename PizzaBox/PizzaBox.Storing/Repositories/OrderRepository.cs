using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Factories;

namespace PizzaBox.Storing.Repositories
{
  public class OrderRepository
  {
    private List<AOrder> _orderLibrary;
    public List<AOrder> OrderLibrary
    {
      get
      {
        return _orderLibrary;
      }
    }
    public OrderRepository()
    {
      Initialize();
    }
    private List<AOrder> Initialize()
    {
      var orderFactory = new OrderFactory();
      if(_orderLibrary == null)
      {
        _orderLibrary = new List<AOrder>();

        _orderLibrary.AddRange(new AOrder[]
        {
          orderFactory.Create<Order>()
        });
      }

      return _orderLibrary;
    }
  }
}