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
      Orders newOrder = new Orders("Five Pastries", "Description", "Price", "Date");
      Assert.AreEqual(typeof(Orders), newOrder.GetType());
    }

    [TestMethod]
    public void GetOrderTitle_ReturnsTitle_String()
    {
      string OrderTitle = "Five Pastries";
      Orders newOrder = new Orders(OrderTitle, "Description", "Price", "Date");
      string result = newOrder.OrderTitle;
      Assert.AreEqual(OrderTitle, result);
    }

    [TestMethod]
    public void SetOrderTitle_SetOrderTitle_String()
    {
      string OrderTitle = "Five Pastries";
      Orders newOrder = new Orders(OrderTitle, "Description", "Price", "Date");
      string updatedOrder = "3 Bread";
      newOrder.OrderTitle = updatedOrder;
      string result = newOrder.OrderTitle;
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
    public void GetAll_ReturnsOrderTitles_OrdersList()
    {
      string OrderTitle1 = "Five Pastries";
      string OrderTitle2 = "3 Bread";
      Orders newOrder1 = new Orders(OrderTitle1, "Description", "Price", "Date");
      Orders newOrder2 = new Orders(OrderTitle2, "Description", "Price", "Date");
      List<Orders> newList = new List<Orders> { newOrder1, newOrder2 };
      List<Orders> result = Orders.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_OrdersInitiateWithAnIdAndGetterReturns_Int()
    {
      string OrderTitle = "Five Pastries";
      Orders newOrder = new Orders(OrderTitle, "Description", "Price", "Date");
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrentOrder_Order()
    {
      string OrderTitle1 = "Five Pastries";
      string OrderTitle2 = "3 Bread";
      Orders newOrder1 = new Orders(OrderTitle1, "Description", "Price", "Date");
      Orders newOrder2 = new Orders(OrderTitle2, "Description", "Price", "Date");
      Orders result = Orders.Find(2);
      Assert.AreEqual(newOrder2, result);
    
    }
  }
}