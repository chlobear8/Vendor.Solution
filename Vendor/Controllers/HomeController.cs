using Microsoft.AspNetCore.Mvc;
using Vendor.Models;

namespace Vendor.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
      Vendor newVendor = new Vendor("Add vendor to Vendor List");
      return View(newVendor);
    }
  }
}