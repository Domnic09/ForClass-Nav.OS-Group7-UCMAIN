using Microsoft.AspNetCore.Mvc;

namespace ASI.Basecode.WebApp.Controllers
{
    public class NavosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
