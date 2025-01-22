using Microsoft.AspNetCore.Mvc;

namespace OtelSitesi.Controllers
{
    public class HakkimizdaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
