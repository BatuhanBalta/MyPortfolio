using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents.LayoutViewComponents
{
    public class _LayouNavbarComponentsPartial : ViewComponent
    {
        MyPortfolioContext MyPortfolioContext = new MyPortfolioContext();

        public IViewComponentResult Invoke()
        {
            ViewBag.toDoListCount = MyPortfolioContext.TodoLists.Where(x=>x.Status == false).Count();
            var values = MyPortfolioContext.TodoLists.Where(x=>x.Status == false).ToList();

            return View(values);
        }
    
    }
}
