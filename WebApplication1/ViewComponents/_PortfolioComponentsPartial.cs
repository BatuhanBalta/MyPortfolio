using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace MyPortfolio.ViewComponents
{
    public class _PortfolioComponentsPartial : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();

        }
    }
}
