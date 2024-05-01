using Microsoft.AspNetCore.Mvc;

namespace UserMessageApp.ViewComponents
{
    public class _SidebarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke ()
        {
            return View();
        }
    }
}
