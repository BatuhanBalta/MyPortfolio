using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents
{
    public class _FooterComponentsPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();

        }

    }
}
