using Microsoft.AspNetCore.Mvc;

namespace SahilPlanProje.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
