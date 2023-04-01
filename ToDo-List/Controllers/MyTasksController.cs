using Microsoft.AspNetCore.Mvc;
using ToDoList.Data;
using ToDoList.Models;

namespace ToDo_List.Controllers
{
    public class MyTasksController : Controller
    {
        private readonly ToDoListContext _db;
        public MyTasksController(ToDoListContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<MyTask> myTasks = _db.Tasks.ToList();
            return View(myTasks);
        }

        public IActionResult Create()
        {
            ViewBag.Priorities = _db.Priorities.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(MyTask myTask)
        {
            _db.Tasks.Add(myTask);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id)
        {
            ViewBag.Priorities = _db.Priorities.ToList();
            MyTask myTask = _db.Tasks.Find(id);
            if (myTask == null)
            {
                return NotFound();
            }
            return View(myTask);
        }

      
    }
}
