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
      Vendors newVendor = new Vendors("test vendor", "test description");
      Assert.AreEqual(typeof(Vendors), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name= "Test Vendor";
      Vendors newVendor = new Vendors(name, "test desciption");
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Test Vendor";
      Vendors newVendor = new Vendors(name, "test description");
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string vendor1 = "Suzie's Cafe";
      string vendor2 = "Trader Joe's";
      Vendors newVendor1 = new Vendors(vendor1, "description");
      Vendors newVendor2 = new Vendors(vendor2, "description");
      List<Vendors> newList = new List<Vendors> { newVendor1, newVendor2 };
      List<Vendors> result = Vendors.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string vendor1 = "Suzie's Cafe";
      string vendor2 = "Trader Joe's";
      Vendors newVendor1 = new Vendors(vendor1, "description");
      Vendors newVendor2 = new Vendors(vendor2, "description");
      Vendors result = Vendors.Find(2);
      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddItem_AssociatesItemWithCategory_ItemList()
    {
      string orderName = "5 Pastries";
      Orders newOrder = new Orders(orderName, "Description", "Price", "Date");
      List<Orders> newList = new List<Orders> { newOrder };
      string name = "Suzie's Cafe";
      Vendors newVendor = new Vendors(name, "description");
      newVendor.AddOrder(newOrder);
      List<Orders> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }
  }
}