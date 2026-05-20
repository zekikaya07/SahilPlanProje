using Microsoft.AspNetCore.Mvc;

namespace SahilPlanProje.WebAdmin.ViewComponents
{
    public class _BodyDefaultComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
