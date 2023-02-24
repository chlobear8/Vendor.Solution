using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vendor.Models;

namespace Vendor.Tests
{
  [TestClass]
  public class VendorTests
  {

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendors newVendor = new Vendors("Suzie's Cafe");
      Assert.AreEqual(typeof(Vendors), newVendor.GetType());
    }

    [TestMethod]
    public void GetVendorName_ReturnsName_String()
    {
      string vendorName = "Suzie's Cafe";
      Vendors newVendor = new Vendors(vendorName);
      string result = newVendor.VendorName;
      Assert.AreEqual(vendorName, result);
    }
  }
}