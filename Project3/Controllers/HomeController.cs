using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LoginPage.Controllers
{
    public class HomeController : Controller
    {
        //GET:
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult FriendList()
        {
            return View();

        }
        public ActionResult MessagePage()
        {
            return View();
        }
        

    }
}