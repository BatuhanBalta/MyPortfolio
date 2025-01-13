using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _SkillComponentsPartial : ViewComponent
    {
        MyPortfolioContext MyPortfolioContext = new MyPortfolioContext();

        public IViewComponentResult Invoke()
        {
            
            var values = MyPortfolioContext.Skills.ToList();
            
            return  View(values);

        }

    }
}
