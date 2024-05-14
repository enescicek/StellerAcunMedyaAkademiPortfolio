using StellerAcunMedyaAkademiPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StellerAcunMedyaAkademiPortfolio.Controllers
{
    public class AboutController : Controller
    {
        StellerAcunMedyaDbEntities db = new StellerAcunMedyaDbEntities();
        
        public ActionResult Index()
        {
            
            var aboutList = db.TblAbout.ToList();
            return View(aboutList);
        }

        public ActionResult DeleteAbout(int id)
        {
            var about = db.TblAbout.Find(id);
            db.TblAbout.Remove(about);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddAbout()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAbout(TblAbout about)
        {
            db.TblAbout.Add(about);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var about = db.TblAbout.Find(id);
            return View(about);
        }

        [HttpPost]

        public ActionResult UpdateAbout(TblAbout about)
        {

            var value = db.TblAbout.FirstOrDefault(x => x.AboutID == about.AboutID);

            value.NameSurname = about.NameSurname;
            value.Title = about.Title;
            value.Description = about.Description;
            value.ImageUrl = about.ImageUrl;
            db.SaveChanges();

            return RedirectToAction("Index");


        }
    }
}