using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Client.ServiceReference1;

namespace Client.Controllers
{
    public class HomeController : Controller
    {
        Service1Client client = new Service1Client();
        public ActionResult Index()
        {
            ViewBag.message1 = "Calling Hello World WCF Service";
            ViewBag.message2 = client.HelloWorld();
            ViewBag.message3 = "Calling GetName WCF Service with Bob Parameter";
            ViewBag.message4 = client.GetName("Bob");
            ViewBag.message5 = "Calling GetAverage WCF Service with (90,95,99)";
            ViewBag.message6 = client.GetAverage(90, 95, 99);
            ViewBag.message7 = "Calling GetMax WCF Service with integer array containing (90, 95, 99, 92)";
            int[] arr = new int[4] {90, 95, 99, 92};
            ViewBag.message8 = client.GetMax(arr);
            ViewBag.message9 = "Calling DoesStudentPass WCF Service with Student object, Bob";
            Student Jim = new Student();
            Jim.StudentName = "Bob";
            Jim.M1 = 90;
            Jim.M2 = 95;
            Jim.M3 = 99;
            ViewBag.message10 = client.DoesStudentPass(Jim);
            return View();
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