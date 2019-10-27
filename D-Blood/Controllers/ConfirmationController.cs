using D_Blood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace D_Blood.Controllers
{
    public class ConfirmationController : Controller
    {
        // GET: Confirmation
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Save()
        {
            return View();
        }

        public ActionResult Save(RegisterDonor RegisterDonor)
        {
            return View();
        }
    }
}