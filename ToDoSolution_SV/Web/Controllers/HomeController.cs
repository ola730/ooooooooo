using Microsoft.AspNetCore.Mvc;
using NTierTodoApp.Business;

namespace NTierTodoApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly TaskService taskService;

        public HomeController(TaskService service)
        {
            taskService = service;
        }

        public IActionResult Index()
        {
            var tasks = taskService.GetTasks();
            return View(tasks);
        }

        [HttpPost]
        public IActionResult AddTask(string title)
        {
            if (!string.IsNullOrWhiteSpace(title))
                taskService.AddTask(title);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult CompleteTask(int id)
        {
            taskService.CompleteTask(id);
            return RedirectToAction("Index");
        }

        // TODO: تنفيذ إجراء لحذف المهمة
       
        
        [HttpPost]
public IActionResult DeleteTask(int id)
{
    taskService.DeleteTask(id);
    return RedirectToAction("Index");
}

    }
}
