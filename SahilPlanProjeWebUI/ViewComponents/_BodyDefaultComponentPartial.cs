using Microsoft.AspNetCore.Mvc;

namespace SahilPlanProje.WebUI.ViewComponents
{
    public class _BodyDefaultComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
