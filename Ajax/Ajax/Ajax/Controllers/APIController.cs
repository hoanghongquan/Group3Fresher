using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Ajax.Models;

namespace Ajax.Controllers
{
    public class ApiController : Controller
    {
        StudentEntities db = new StudentEntities();
        // GET: API
        [HttpGet]
        public JsonResult Index()
        {
            var enti = db.Studens.ToList();
            return Json(enti, JsonRequestBehavior.AllowGet);

        }
        [HttpGet]
        public JsonResult GetUser()
        {
            var enti = db.Users.ToList();
            return Json(enti, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public JsonResult PostUser(string users)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            User newUser = serializer.Deserialize<User>(users);
            User user = new User { Fullname = newUser .Fullname, Gender = newUser .Gender, Password = newUser .Password, Username = newUser .Username};
            db.Users.Add(user);
            db.SaveChanges();
            
           return Json("Registration Success!", JsonRequestBehavior.AllowGet);
        }
    }
}