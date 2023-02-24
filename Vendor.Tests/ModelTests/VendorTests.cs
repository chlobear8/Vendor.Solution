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
      Vendors newVendor = new Vendors();
      Assert.AreEqual(typeof(Vendors), newVendor.GetType());
    }
  }
}