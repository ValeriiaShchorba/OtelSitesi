using Microsoft.AspNetCore.Mvc;
using OtelSitesi.Data;
using OtelSitesi.Models;

namespace OtelSitesi.Controllers
{
    public class RezervasyonController : Controller
    {
        private readonly HotelContext _context;

        public RezervasyonController(HotelContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult YeniRezervasyon()
        {
            return View();
        }

        [HttpPost]
        public IActionResult YeniRezervasyon(Rezervasyonlar rezervasyon)
        {
            if (ModelState.IsValid)
            {
                _context.Rezervasyonlar.Add(rezervasyon);
                _context.SaveChanges();
                return RedirectToAction("BasariliRezervasyon");
            }
            return View(rezervasyon);
        }

        public IActionResult BasariliRezervasyon()
        {
            return View();
        }
    }
}