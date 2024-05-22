using Microsoft.AspNetCore.Mvc;

namespace AgencyWeb.Areas.AgencyAdmin.Controllers
{
    [Area("Manage")]
    public class Dashboard : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
