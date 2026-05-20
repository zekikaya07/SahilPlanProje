using Microsoft.AspNetCore.Mvc;

namespace SahilPlanProje.WebAdmin.ViewComponents
{
    public class _FooterDefaultComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}