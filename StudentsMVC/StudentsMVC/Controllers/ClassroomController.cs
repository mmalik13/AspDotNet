using StudentsMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentsMVC.Controllers
{
    public class ClassroomController : Controller
    {
        // GET: Classroom
        public ActionResult Index()
        {
            return View(MvcApplication.classroomList);
        }

        // GET: Classroom/Details/5
        public ActionResult Details(int id)
        {
            Classroom classroom = MvcApplication.classroomList.Where(s => s.Id == id).FirstOrDefault();
            return View(classroom);
        }

        // GET: Classroom/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Classroom/Create
        [HttpPost]
        public ActionResult Create(Classroom classroom)
        {
            try
            {
                //Increment classroom count to use as ID (No DB)
                classroom.Id = ++MvcApplication.classroomsIdCount;
                //Save in classroom List
                MvcApplication.classroomList.Add(classroom);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Classroom/Edit/5
        public ActionResult Edit(int id)
        {
            Classroom classroom = MvcApplication.classroomList.Where(s => s.Id == id).FirstOrDefault();
            return View(classroom);
        }

        // POST: Classroom/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Classroom classroom)
        {
            try
            {
                // TODO: Add update logic here
                Classroom tempClassroom = MvcApplication.classroomList.Where(s => s.Id == id).FirstOrDefault();

                //By reference -> No need to update element in list (already updated)
                tempClassroom.Name = classroom.Name;
                tempClassroom.Number = classroom.Number;
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Classroom/Delete/5
        public ActionResult Delete(int id)
        {
            Classroom classroom = MvcApplication.classroomList.Where(s => s.Id == id).FirstOrDefault();
            return View(classroom);
        }

        // POST: Classroom/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Classroom tempClassroom = MvcApplication.classroomList.Where(s => s.Id == id).FirstOrDefault();
                MvcApplication.classroomList.Remove(tempClassroom);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
