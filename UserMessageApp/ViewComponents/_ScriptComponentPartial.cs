using Microsoft.AspNetCore.Mvc;

namespace UserMessageApp.ViewComponents
{
    public class _ScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke ()
        {
            return View();
        }
    }
}
