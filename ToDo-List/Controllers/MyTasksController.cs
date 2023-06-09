﻿using Microsoft.AspNetCore.Mvc;
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
            ViewBag.Priorities = _db.Priorities.ToList();
            ViewBag.Status = _db.Status.ToList();
            IEnumerable<MyTask> myTasks = _db.Tasks.ToList();
            return View(myTasks);
        }

        public IActionResult Create()
        {
            ViewBag.Priorities = _db.Priorities.ToList();
            ViewBag.Status = _db.Status.ToList();

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
            ViewBag.Status = _db.Status.ToList();

            MyTask myTask = _db.Tasks.Find(id);
            if (myTask == null)
            {
                return NotFound();
            }
            return View(myTask);
        }



        public IActionResult Delete(int id)
        {
            MyTask myTask = _db.Tasks.Find(id);
            if (myTask == null || myTask.StatusId == 2)
            {
                return NotFound();
            }
            return View(myTask);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            MyTask myTask = _db.Tasks.Find(id);
            if (myTask == null)
            {
                return NotFound();
            }
            _db.Tasks.Remove(myTask);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult ChangeStatus(int id)
        {
            MyTask myTask = _db.Tasks.Find(id);
            if (myTask.StatusId == 1)
                myTask.DateOpen = DateTime.Now;

            myTask.StatusId++;



            _db.Update(myTask);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
