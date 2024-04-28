using Microsoft.AspNetCore.Mvc;

namespace Color_Media.API.Controllers
{
    public class CommoncategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
