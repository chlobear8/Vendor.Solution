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

    [HttpGet("/orders/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/orders")]
    public ActionResult Create(string orderName)
    {
      Orders newOrder = new Orders(orderName);
      return RedirectToAction("Index");
    }

    [HttpPost("/orders/delete")]
    public ActionResult DeleteAll()
    {
      Orders.ClearAll();
      return View();
    }

    [HttpGet("/orders/{id}")]
    public ActionResult Show(int id)
    {
      Orders foundOrder = Orders.Find(id);
      return View(foundOrder);
    }
  }
}