using Microsoft.AspNetCore.Mvc;

namespace OtelSitesi.Controllers
{
    public class GaleriController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
