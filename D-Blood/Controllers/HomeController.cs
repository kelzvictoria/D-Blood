using D_Blood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using D_Blood.ViewModels;

namespace D_Blood.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController()
		{
			_context = new ApplicationDbContext();
		}

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            RegisterDonorViewModel donor = TempData["Message"] as RegisterDonorViewModel;
            return View(donor);
        }

        public ViewResult Donors()
        {
            //var donors = _context.RegisterDonors.ToList();
            //var viewModel = new RegisterDonorViewModel
            //{
            //    RegisterDonors = donors
            //};
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