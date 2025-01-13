using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.Controllers
{
    public class MessageController : Controller
    {

        MyPortfolioContext myPortfolioContext = new MyPortfolioContext();
        public IActionResult Inbox()
        {
            var values = myPortfolioContext.Messages.ToList();

            return View(values);
        }

        public IActionResult ChangeIsReadToTrue(int id)
        {

            var value = myPortfolioContext.Messages.Find(id);
            value.IsRead = true;
            myPortfolioContext.SaveChanges();
            return RedirectToAction("Inbox");
        }

        public IActionResult ChangeIsReadToFasle(int id)
        {
            var values = myPortfolioContext.Messages.Find(id);
            values.IsRead = false;
            myPortfolioContext.SaveChanges();
            return RedirectToAction("Inbox");



        }

        public IActionResult DeleteMessage(int id)
        {
            var value = myPortfolioContext.Messages.Find(id);
            myPortfolioContext.Messages.Remove(value);
            myPortfolioContext.SaveChanges();
            return RedirectToAction("Inbox");
            
        }
          
        public IActionResult MessageDetail(int id)
        {

            var value = myPortfolioContext.Messages.Find(id);
            return View(value);
        }
    
    
    
    }
}
