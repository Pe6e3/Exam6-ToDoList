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
    }
}
