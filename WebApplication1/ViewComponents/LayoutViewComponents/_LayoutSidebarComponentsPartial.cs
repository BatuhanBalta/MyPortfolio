using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents.LayoutViewComponents
{
    public class _LayoutSidebarComponentsPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();


        }
    }
}
