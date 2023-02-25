using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Vendor.Models;

namespace Vendor.Controllers
{
  public class VendorsController : Controller
  {

    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendors> allVendors = Vendors.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName)
    {
      Vendors newVendor = new Vendors(vendorName);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendors selectedVendor = Vendors.Find(id);
      List<Orders> orderName = selectedVendor.Orders;
      model.Add("vendors", selectedVendor);
      model.Add("orders", orderName);
      return View(model);
    }

    [HttpPost("/vendors/{vendorsId}/orders")]
    public ActionResult Create(int vendorsId, string orderName)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendors foundVendors = Vendors.Find(vendorsId);
      Item newItem = new Item(orderName);
      foundVendors.AddOrder(newOrder);
      List<Orders> vendorOrders = foundVendors.Orders;
      model.Add("orders", vendorOrders);
      model.Add("vendors", foundVendors);
      return View("Show", model);
    }

  }
}