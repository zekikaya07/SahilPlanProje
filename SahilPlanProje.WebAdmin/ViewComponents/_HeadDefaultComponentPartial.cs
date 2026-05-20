using Microsoft.AspNetCore.Mvc;

namespace SahilPlanProje.WebAdmin.ViewComponents
{
    public class _HeadDefaultComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
