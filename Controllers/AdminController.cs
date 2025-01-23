using Microsoft.AspNetCore.Mvc;
using OtelSitesi.Data;
using OtelSitesi.Models;
using System.Drawing;

namespace OtelSitesi.Controllers
{
    public class AdminController : Controller
    {
        private readonly HotelContext _context;

        public AdminController(HotelContext context)
        {
            _context = context;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Ayarlar()
        {
            // Varsayılan olarak admin bilgilerini alalım
            var admin = _context.Admins.FirstOrDefault(); // Sadece bir admin için varsayılan yapı
            return View(admin);
        }

        [HttpPost]
        public IActionResult Ayarlar(Admin admin)
        {
            if (ModelState.IsValid)
            {
                var existingAdmin = _context.Admins.FirstOrDefault();
                if (existingAdmin != null)
                {
                    existingAdmin.KullaniciAdi = admin.KullaniciAdi;
                    existingAdmin.Eposta = admin.Eposta;

                    // Şifre değişikliği
                    if (!string.IsNullOrEmpty(admin.Sifre))
                    {
                        existingAdmin.Sifre = admin.Sifre;
                    }

                    _context.SaveChanges();
                    ViewData["Success"] = "Bilgiler başarıyla güncellendi.";
                }
                else
                {
                    ViewData["Error"] = "Güncelleme işlemi başarısız oldu.";
                }
            }
            return View(admin);
        }



            [HttpPost]
        public IActionResult Login(string username, string password)
        {
            // Veritabanında kullanıcıyı kontrol et
            var admin = _context.Admins.FirstOrDefault(a => a.KullaniciAdi == username && a.Sifre == password);

            if (admin != null)
            {
               
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                // Başarısız giriş
                ViewData["Error"] = "Geçersiz kullanıcı adı veya şifre.";
                return View();
            }
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(string username, string password, string email)
        {
            if (ModelState.IsValid)
            {
                var newAdmin = new Admin
                {
                    KullaniciAdi = username,
                    Sifre = password,
                    Eposta = email
                };

                _context.Admins.Add(newAdmin);
                _context.SaveChanges();

                TempData["Success"] = "Yönetici başarıyla kaydedildi!";
                return RedirectToAction("Login");
            }

            ViewData["Error"] = "Bir hata oluştu. Lütfen bilgilerinizi kontrol edin.";
            return View();
        }
    }
}