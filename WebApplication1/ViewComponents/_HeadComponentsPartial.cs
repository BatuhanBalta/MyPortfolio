using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents
{
    public class _HeadComponentsPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }




    }
}
