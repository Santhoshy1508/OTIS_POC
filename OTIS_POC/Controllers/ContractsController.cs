using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OTIS_POC.Controllers
{
    public class ContractsController : Controller
    {
        // GET: Contracts
        public ActionResult New()
        {
            return View();
        }
    }
}