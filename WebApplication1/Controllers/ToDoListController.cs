using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class ToDoListController : Controller
    {
        MyPortfolioContext myPortfolioContext = new MyPortfolioContext();

        public IActionResult Index()
        {
            var values = myPortfolioContext.TodoLists.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateToDoList()
        {
            return View();

        }
        [HttpPost]
        public IActionResult CreateToDoList(TodoList toDoList)
        {
            myPortfolioContext.TodoLists.Add(toDoList);
            myPortfolioContext.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult DeleteToDolist(int id)
        {

            var value = myPortfolioContext.TodoLists.Find(id);
            myPortfolioContext.TodoLists.Remove(value);
            myPortfolioContext.SaveChanges();
            return RedirectToAction("Inde");

        }
        [HttpGet]
        public IActionResult UpdateToDoList(int id)
        {
            var value = myPortfolioContext.TodoLists.Find(id);
            return View(value);

        }
        [HttpPost]
        public IActionResult UpdateToDoList(TodoList toDoList)
        {
            toDoList.Status = false;
            myPortfolioContext.TodoLists.Update(toDoList);
            myPortfolioContext.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult ChangeToDoListStatusToTrue(int id)
        {

            var value = myPortfolioContext.TodoLists.Find(id);
            value.Status = true;
            myPortfolioContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult ChangeToDoListStatusToFasle(int id)
        {
            var value = myPortfolioContext.TodoLists.Find(id);
            value.Status = false;
            myPortfolioContext.SaveChanges();
            return RedirectToAction("Index");
            
        }
    
    
    
    
    
    }
}
