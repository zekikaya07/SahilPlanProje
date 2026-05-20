using Microsoft.AspNetCore.Mvc;

namespace SahilPlanProje.WebUI.ViewComponents
{
    public class _SliderDefaultComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
