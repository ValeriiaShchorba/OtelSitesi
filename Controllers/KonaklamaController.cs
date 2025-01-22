using Microsoft.AspNetCore.Mvc;

namespace OtelSitesi.Controllers
{
    public class KonaklamaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
