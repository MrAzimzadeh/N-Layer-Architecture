using Microsoft.AspNetCore.Mvc;

namespace WebUI.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        [Area(nameof(Admin))]

        public IActionResult Index()
        {
            return View();
        }
    }
}
