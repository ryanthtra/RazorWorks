﻿using Microsoft.AspNetCore.Mvc;
using RazorWorks.Models;

namespace RazorWorks.Controllers
{



  public class HomeController : Controller
  {
    public ViewResult Index()
    {
      Product[] array = {
        new Product {Name = "Kayak", Price = 275M},
        new Product {Name = "Lifejacket", Price = 48.95M},
        new Product {Name = "Soccer ball", Price = 19.5M},
        new Product {Name = "Corner flag", Price = 34.95M}
      };

      return View(array);
    }
  }
}
