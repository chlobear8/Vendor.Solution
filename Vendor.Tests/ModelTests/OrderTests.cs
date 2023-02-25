using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vendor.Models;
using System.Collections.Generic;
using System;

namespace Vendor.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Orders.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Orders newOrder = new Orders("Five Pastries");
      Assert.AreEqual(typeof(Orders), newOrder.GetType());
    }

    [TestMethod]
    public void GetOrderName_ReturnsName_String()
    {
      string OrderName = "Five Pastries";
      Orders newOrder = new Orders(OrderName);
      string result = newOrder.OrderName;
      Assert.AreEqual(OrderName, result);
    }

    [TestMethod]
    public void SetOrderName_SetOrderName_String()
    {
      string OrderName = "Five Pastries";
      Orders newOrder = new Orders(OrderName);
      string updatedOrder = "3 Bread";
      newOrder.OrderName = updatedOrder;
      string result = newOrder.OrderName;
      Assert.AreEqual(updatedOrder, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
    List<Orders> newList = new List<Orders> { };
    List<Orders> result = Orders.GetAll();
    CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrderNames_OrdersList()
    {
      string OrderName1 = "Five Pastries";
      string OrderName2 = "3 Bread";
      Orders newOrder1 = new Orders(OrderName1);
      Orders newOrder2 = new Orders(OrderName2);
      List<Orders> newList = new List<Orders> { newOrder1, newOrder2 };
      List<Orders> result = Orders.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_OrdersInitiateWithAnIdAndGetterReturns_Int()
    {
      string OrderName = "Five Pastries";
      Orders newOrder = new Orders(OrderName);
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrentOrder_Order()
    {
      string OrderName1 = "Five Pastries";
      string OrderName2 = "3 Bread";
      Orders newOrder1 = new Orders(OrderName1);
      Orders newOrder2 = new Orders(OrderName2);
      Orders result = Orders.Find(2);
      Assert.AreEqual(newOrder2, result);
    }
  }
}