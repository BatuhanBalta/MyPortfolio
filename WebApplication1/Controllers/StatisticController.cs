using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.Controllers
{
    public class StatisticController : Controller
    {
        MyPortfolioContext MyPortfolioContext = new MyPortfolioContext();
        public IActionResult Index()
        {
            ViewBag.v1 = MyPortfolioContext.Skills.Count();
            ViewBag.v2 = MyPortfolioContext.Messages.Count();
            ViewBag.v3 = MyPortfolioContext.Messages.Where(x=>x.IsRead == false).Count();
            ViewBag.v4 = MyPortfolioContext.Messages.Where(x=>x.IsRead == true).Count();
            
            return View();
        }
    }
}
