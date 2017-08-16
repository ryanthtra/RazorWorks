using Microsoft.AspNetCore.Mvc;
using RazorWorks.Models;

namespace RazorWorks.Controllers
{



  public class HomeController : Controller
  {
    public ViewResult Index()
    {
      Product myProduct = new Product {
        ProductID = 1,
        Name = "Kayak",
        Description = "A boat for one person",
        Category = "Watersports",
        Price = 275M
      };

      ViewBag.StockLevel = 0;

      return View(myProduct);
    }
  }
}
