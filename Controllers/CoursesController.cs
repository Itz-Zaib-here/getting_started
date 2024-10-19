using getting_started.Data;
using getting_started.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace getting_started.Controllers
{

    //CRUD in MVC
    public class CoursesController : Controller
    {

        private readonly DataContext _Context;
        public CoursesController(DataContext context)
        {
            _Context = context;
        }

        /// <summary>
        /// get section of courses
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        public IActionResult Index()
        {
            var courses = _Context.Courses.ToList();
            return View(courses);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var course = _Context.Courses.Where(x => x.Id == id).FirstOrDefault();
            return View(course);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var course = _Context.Courses.Where(x=>x.Id == id).FirstOrDefault();
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var course = _Context.Courses.Where(x => x.Id == id).FirstOrDefault();
            return View();
        }

        /// <summary>
        /// post section of courses
        /// </summary>
        /// <returns></returns>
        /// 
        

        [HttpPost]
        public IActionResult Create(Course model)
        {
            _Context.Courses.Add(model);
            _Context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(Course model)
        {
            _Context.Courses.Update(model);
            _Context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(Course model)
        {
            _Context.Courses.Remove(model);
            _Context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
