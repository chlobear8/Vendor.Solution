using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vendor.Models;
using System.Collections.Generic;
using System;

namespace Vendor.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendors.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendors newVendor = new Vendors("test vendor");
      Assert.AreEqual(typeof(Vendors), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name= "Test Vendor";
      Vendors newVendor = new Vendors(name);
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Test Vendor";
      Vendors newVendor = new Vendors(name);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string vendor1 = "Suzie's Cafe";
      string vendor2 = "Trader Joe's";
      Vendors newVendor1 = new Vendors(vendor1);
      Vendors newVendor2 = new Vendors(vendor2);
      List<Vendors> newList = new List<Vendors> { newVendor1, newVendor2 };
      List<Vendors> result = Vendors.GetAll();
      CollectionAssert.AreEqual(newList, result);
  }


  }
}