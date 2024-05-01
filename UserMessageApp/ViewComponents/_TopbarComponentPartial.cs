using Microsoft.AspNetCore.Mvc;

namespace UserMessageApp.ViewComponents
{
    public class _TopbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke ()
        {
            return View();
        }
    }
}
