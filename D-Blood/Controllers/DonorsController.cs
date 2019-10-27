using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace D_Blood.Controllers
{
    public class DonorsController : Controller
    {
        // GET: Donors
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult List()
        {
            return View();
        }
    }
}