using System.Collections.Generic;

namespace Vendor.Models
{
  public class Vendors
  {
    public string VendorName { get; set; }
    private static List<Vendors> _instances = new List<Vendors> {};

    public Vendors(string vendorName)
    {
      VendorName = vendorName;
      _instances.Add(this);
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Vendors> GetAll()
    {
      return _instances;
    }
  }
}