using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vendor.Models;
using System.Collections.Generic;
using System;

namespace Vendor.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendors newVendor = new Vendors("test vendor");
      Assert.AreEqual(typeof(Vendors), newVendor.GetType());
    }

  }
}