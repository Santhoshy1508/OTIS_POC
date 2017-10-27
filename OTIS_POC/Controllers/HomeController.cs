using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OTIS_POC.Models;

namespace OTIS_POC.Controllers
{
    public class HomeController : Controller
    {
        private OTIS_POCEntitiesNew _context;

        public HomeController()
        {
            _context = new OTIS_POCEntitiesNew();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult LayoutData()
        {
            var emp= _context.Vw_Users.SingleOrDefault(m => m.LoginId == User.Identity.Name);
           
            
            //var empDetails = new UserDetails
            //{

            //};

            return PartialView("~/Views/_UserDetails.cshtml", emp);
        }

        public ActionResult Index()
        {
            
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