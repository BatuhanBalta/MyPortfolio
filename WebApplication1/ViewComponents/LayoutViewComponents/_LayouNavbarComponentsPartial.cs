using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents.LayoutViewComponents
{
    public class _LayouNavbarComponentsPartial : ViewComponent
    {
    
        public IViewComponentResult Invoke()
        {

            return View();
        }
    
    }
}
