using Microsoft.AspNetCore.Mvc;
using Vendor.Models;
using System.Collections.Generic;
using System;

namespace Vendor.Controllers
{
  public class OrdersController : Controller
  {

    [HttpGet("/vendors/{vendorsId}/orders/new")]
    public ActionResult New(int vendorsId)
    {
      Vendors vendors = Vendors.Find(vendorsId);
      return View(vendors);
    }
    
    [HttpGet("/vendors/{vendorsId}/orders/{ordersId}")]
    public ActionResult Show(int vendorsId, int ordersId)
    {
      Orders orders = Orders.Find(ordersId);
      Vendors vendors = Vendors.Find(vendorsId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("orders", orders);
      model.Add("vendors", vendors);
      return View(model);
    }
  }
}