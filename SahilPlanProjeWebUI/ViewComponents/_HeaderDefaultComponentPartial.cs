using Microsoft.AspNetCore.Mvc;

namespace SahilPlanProje.WebUI.ViewComponents
{
    public class _HeaderDefaultComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
