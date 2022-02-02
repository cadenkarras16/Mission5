using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DateMe.Models;
using Microsoft.EntityFrameworkCore;

namespace DateMe.Controllers
{
    public class HomeController : Controller
    { 
        private DateApplicationContext dateContext { get; set; } 

        //Contructor

        public HomeController( DateApplicationContext someName)
        {
            dateContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]

        public IActionResult DatingApplication()
        {
            ViewBag.Majors = dateContext.Majors.ToList();

            return View();
        }

        [HttpPost]

        public IActionResult DatingApplication(ApplicationResponse ar)
        {
            if (ModelState.IsValid)
            {
                dateContext.Add(ar);
                dateContext.SaveChanges();

                return View("Confirmation", ar);
            }
            else //if its invalid
            {
                ViewBag.Majors = dateContext.Majors.ToList();

                return View();
            }
        }

        public IActionResult Waitlist()
        {
            var applications = dateContext.Responses
                .Include(x => x.Major) //this brings in the other table based on the foreign key
                .Where(x => x.CreeperStalker == false)
                .OrderBy(x => x.LastName)
                .ToList();

            return View(applications);
        }


        [HttpGet]

        public IActionResult Edit(int applicationid)
        {
            ViewBag.Majors = dateContext.Majors.ToList();

            var application = dateContext.Responses.Single(x => x.ApplicationID == applicationid);

            return View("DatingApplication", application);
        }

        [HttpPost]

        public IActionResult Edit (ApplicationResponse blah)
        {
            dateContext.Update(blah);
            dateContext.SaveChanges();

            return RedirectToAction("Waitlist");
        }

        [HttpGet]
        public IActionResult Delete(int applicationid)
        {
            var application = dateContext.Responses.Single(x => x.ApplicationID == applicationid);

            return View(application);
        }

        [HttpPost]
        public IActionResult Delete(ApplicationResponse ar)
        {

            dateContext.Responses.Remove(ar);
            dateContext.SaveChanges();


            return RedirectToAction("Waitlist");
        }
    }
}
