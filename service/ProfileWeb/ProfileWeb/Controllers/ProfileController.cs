using Microsoft.AspNetCore.Mvc;

namespace ProfileWeb.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
