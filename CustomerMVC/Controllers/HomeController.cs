using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dal;

namespace CustomerMVC.Controllers
{
    public class HomeController : Controller
    {
        operations operations = null;

        public HomeController()
        {
            operations = new operations();
        }
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            bool valid = operations.ValidateUser(Request["email"], Request["password"]);
            if (valid)
            {
                return RedirectToAction("Loginpage");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        public ActionResult Loginpage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Loginpage(FormCollection collection)
        {
            custloginfo c = new custloginfo();
            c.logid = Int32.Parse(Request["logid"]);
            c.custemail = Request["custemail"];
            c.custname = Request["custname"];
            c.logstatus = Request["logstatus"];
            c.userid = Int32.Parse(Request["userid"]);
            c.descroption= Request["description"];
            operations.Insert(c);
            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}