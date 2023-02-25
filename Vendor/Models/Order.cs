using System.Collections.Generic;

namespace Vendor.Models
{
  public class Orders
  {
    public string OrderTitle { get; set; }
    public string OrderDetails { get; set; }
    public string OrderPrice { get; set; }
    public string OrderDate { get; set; }
    public int Id { get; }
    private static List<Orders> _instances = new List<Orders> {};

    public Orders(string orderTitle, string orderDetails, string orderPrice, string orderDate)
    {
      OrderTitle = orderTitle;
      OrderDetails = orderDetails;
      OrderPrice = orderPrice;
      OrderDate = orderDate;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Orders> GetAll()
    {
      return _instances;
    }

    public static Orders Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}