using Microsoft.AspNetCore.Mvc;

namespace UserMessageApp.ViewComponents
{
    public class _HeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke ()
        {
            return View();
        }
    }
}
