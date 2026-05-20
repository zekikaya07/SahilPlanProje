using Microsoft.AspNetCore.Mvc;

namespace SahilPlanProje.WebUI.ViewComponents
{
    public class _CopyrightDefaultComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
