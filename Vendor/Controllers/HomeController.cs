using Microsoft.AspNetCore.Mvc;
using Vendor.Models;

namespace Vendor.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      List<Vendors> allVendors = Vendors.GetAll();
      return View(allVendors);
    }

    [Route("/vendors/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName)
    {
      Vendors newVendor = new Vendor(vendorName);
      return RedirectToAction("Index");
    }
  }
}