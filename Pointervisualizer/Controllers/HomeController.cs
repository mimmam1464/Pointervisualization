using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pointervisualizer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Chapter1()
        {
            ViewBag.pageName = "Chapter 1";
            return View();
        }
        public ActionResult Chapter2()
        {
            ViewBag.pageName = "Chapter 2";
            return View();
        }
        public ActionResult Chapter3()
        {
            ViewBag.pageName = "Chapter 3";
            return View();
        }
        public ActionResult Chapter4()
        {
            ViewBag.pageName = "Chapter 4";
            return View();
        }
        public ActionResult Chapter5()
        {
            ViewBag.pageName = "Chapter 5";
            return View();
        }
        public ActionResult Chapter6()
        {
            ViewBag.pageName = "Chapter 6";
            return View();
        }
        public ActionResult Chapter7()
        {
            ViewBag.pageName = "Chapter 7";
            return View();
        }

        public ActionResult Sandbox()
        {
            ViewBag.pageName = "Sandbox";
            return View();
        }
        
       
        public ActionResult Index()
        {
            return View();
        }
    }
}