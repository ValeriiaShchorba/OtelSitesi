using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OtelSitesi.Models;

namespace OtelSitesi.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            
           
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Rooms()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Reserve(string name, DateTime date)
        {
            // Rezervasyonu i�leyin (veritaban�na kaydedin)
            return RedirectToAction("Index");
        }

    }
}
