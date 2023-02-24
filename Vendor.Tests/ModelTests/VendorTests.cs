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

    [TestMethod]
    public void SetVendorName_SetVendorName_String()
    {
      string vendorName = "Suzie's Cafe";
      Vendors newVendor = new Vendors(vendorName);
      string updatedVendor = "Trader Joe's";
      newVendor.VendorName = updatedVendor;
      string result = newVendor.VendorName;
      Assert.AreEqual(updatedVendor, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_VendorList()
    {
    List<Vendors> newList = new List<Vendors> { };
    List<Vendors> result = Vendors.GetAll();
    CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsVendorNames_VendorsList()
    {
      string vendorName1 = "Suzie's Cafe";
      string vendorName2 = "Trader Joe's";
      Vendors newVendor1 = new Vendors(vendorName1);
      Vendors newVendor2 = new Vendors(vendorName2);
      List<Vendors> newList = new List<Vendors> { newVendor1, newVendor2 };
      List<Vendors> result = Vendors.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}