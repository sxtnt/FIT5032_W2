using FIT5032_MyCodeSnippet.Models.HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FIT5032_MyCodeSnippet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            //ViewBag.Message = "Your application description page.";
            Models.HelloWorld.Hello hello = new Hello();
            ViewBag.Message = hello.GetHello();
            Models.Exercise.ExampleDictionary ed = new Models.Exercise.ExampleDictionary();
            ed.Example();
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}