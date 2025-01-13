using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class ExperienceController : Controller
    {

        MyPortfolioContext MyPortfolioContext = new MyPortfolioContext ();
        public IActionResult ExperienceList()
        {
            var values = MyPortfolioContext.Experiences.ToList ();

            return View(values);
        }

        [HttpGet] // Bu kısım sayfa direk yüklenince çalışır yani ilk açıldığında
        public IActionResult CreateExperience()
        {
            return View();

        }
        
        [HttpPost] // Burada ise sayfada bir butona tıklandığı zaman çalışacak
        public IActionResult CreateExperience(Experience experience)
        {
            MyPortfolioContext.Experiences.Add(experience);
            MyPortfolioContext.SaveChanges();
            return RedirectToAction("ExperienceList");

        }
        public IActionResult DeleteExperience(int id)
        {
            var values = MyPortfolioContext.Experiences.Find(id);
            MyPortfolioContext.Remove(values);
            MyPortfolioContext.SaveChanges ();
            return RedirectToAction("ExperienceList");

        }
        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var values= MyPortfolioContext.Experiences.Find (id);
            return View(values);

        }
        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {

            MyPortfolioContext.Experiences.Update(experience);
            MyPortfolioContext.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
    
    }
}
