using Microsoft.AspNetCore.Mvc;

namespace TagHelpers.Controllers
{
    public class TagHelperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
