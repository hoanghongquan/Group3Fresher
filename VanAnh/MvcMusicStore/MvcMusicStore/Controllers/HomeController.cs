using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class HomeController : Controller
    {
        //public string Index()
        //{
        //    return "nguyễn thị vân anh";
        //}
        public ActionResult Index()
        {
            return View();
        }
    }

}