using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using System.Diagnostics.Metrics;

namespace MyPortfolio.ViewComponents
{
    public class _FeatureComponentsPartial : ViewComponent
    {
        MyPortfolioContext MyPortfolioContext = new MyPortfolioContext();
        

        public IViewComponentResult Invoke()
        {
            var values = MyPortfolioContext.Features.ToList();
            return View(values);

        }



    }
}
