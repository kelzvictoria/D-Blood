using D_Blood.Models;
using D_Blood.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace D_Blood.Controllers
{
    public class RegisterDonorController : Controller
    {
        public ApplicationDbContext _context;

        public RegisterDonorController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: RegisterDonor
        public ActionResult RegisterDonor()
        {
            var viewModel = new RegisterDonorViewModel
            {
                RegisterDonor = new RegisterDonor()
            };
            return View("RegisterDonor", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(RegisterDonor donor)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new RegisterDonorViewModel
                {
                    RegisterDonor = donor
                };
                return View("RegisterDonor", viewModel);
            }


            if (donor.Id == 0)
            {
                _context.RegisterDonors.Add(donor);
            }

            _context.SaveChanges();
            TempData["Message"] = "Your data " + donor.Name + "has been saved successfully";
            return RedirectToAction("RegisterDonor");
            //return RedirectToAction("Index", "Home");
        }
        
    }
}