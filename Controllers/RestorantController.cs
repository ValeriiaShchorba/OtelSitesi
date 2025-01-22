using Microsoft.AspNetCore.Mvc;

namespace OtelSitesi.Controllers
{
    public class RestorantController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
