using Microsoft.AspNetCore.Mvc;
using OtelSitesi.Data;
using OtelSitesi.Models;

namespace OtelSitesi.Controllers
{
    public class IletisimController : Controller
    {
        private readonly HotelContext _context;
        public IletisimController(HotelContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string name, string email, string message)
        {
            if (ModelState.IsValid)
            {
                var newMessage = new Mesajlar
                {
                    AdSoyad = name,
                    Eposta = email,
                    Mesaj = message,
                    OlusturulmaTarihi = DateTime.Now
                };

                _context.Mesajlar.Add(newMessage);
                _context.SaveChanges();

                ViewData["Success"] = "Mesaj başarıyla gönderildi!";
                return View();
            }

            ViewData["Error"] = "Mesaj gönderilemedi. Lütfen tekrar deneyin.";
            return View();
        }
    }
}
