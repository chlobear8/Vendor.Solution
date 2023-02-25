using Microsoft.AspNetCore.Mvc;
using Vendor.Models;
using System.Collections.Generic;
using System;

namespace Order.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/orders")]
    public ActionResult Index()
    {
      List<Orders> allOrders = Orders.GetAll();
      return View(allOrders);
    }

    [HttpGet("/vendors/{vendorsId}/orders/new")]
    public ActionResult New(int vendorsId)
    {
      Vendors vendors = Vendors.Find(vendorsId);
      return View(vendor);
    }

    // [HttpPost("/orders")]
    // public ActionResult Create(string orderName)
    // {
    //   Orders newOrder = new Orders(orderName);
    //   return RedirectToAction("Index");
    // }

    // [HttpPost("/orders/delete")]
    // public ActionResult DeleteAll()
    // {
    //   Orders.ClearAll();
    //   return View();
    // }

    [HttpGet("/vendors/{vendorsId}/orders/{ordersId}")]
    public ActionResult Show(int vendorsId, int ordersId)
    {
      Orders orders = Orders.Find(ordersId);
      Vendors vendors = Vendors.Find(vendorsId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("orders", orders);
      model.Add("venders", vender);
      return View(model);
    }
  }
}