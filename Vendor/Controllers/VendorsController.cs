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
      List<Orders> vendorOrders = selectedVendor.Orders;
      model.Add("vendors", selectedVendor);
      model.Add("orders", vendorOrders);
      return View(model);
    }


  }
}