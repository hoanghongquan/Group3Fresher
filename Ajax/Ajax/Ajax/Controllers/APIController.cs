using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ajax.Models;

namespace Ajax.Controllers
{
    public class ApiController : Controller
    {
        StudentEntities db = new StudentEntities();
        // GET: API
        public ActionResult Index()
        {
            //List<Student> students = new List<Student>
            //{
            //    new Student{Id = 1,FullName = "Nguyen Van A",Gender = "Nam"},
            //    new Student{Id = 2,FullName = "Nguyen Van B",Gender = "Nu"},
            //    new Student{Id = 3,FullName = "Nguyen Van C",Gender = "Nam"},
            //    new Student{Id = 4,FullName = "Nguyen Van D",Gender = "Nu"},
            //    new Student{Id = 5,FullName = "Nguyen Van E",Gender = "Nam"},
            //    new Student{Id = 6,FullName = "Nguyen Van F",Gender = "Nu"},
            //    new Student{Id = 7,FullName = "Nguyen Van G",Gender = "Nam"},
            //    new Student{Id = 8,FullName = "Nguyen Van H",Gender = "Nu"},
            //    new Student{Id = 9,FullName = "Nguyen Van I",Gender = "Nam"},
            //};
            //return Json(students, JsonRequestBehavior.AllowGet);

           
            var enti = db.Studens.ToList();

            return Json(enti, JsonRequestBehavior.AllowGet);

        }
        [HttpGet]
        public ActionResult LoadData()
        {
            var enti = db.Studens.ToList();

            return Json(enti, JsonRequestBehavior.AllowGet);

        }
    }
}