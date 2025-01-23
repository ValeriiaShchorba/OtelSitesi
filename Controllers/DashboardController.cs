using Microsoft.AspNetCore.Mvc;

namespace OtelSitesi.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
