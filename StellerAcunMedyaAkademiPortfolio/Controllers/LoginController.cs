using StellerAcunMedyaAkademiPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace StellerAcunMedyaAkademiPortfolio.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        StellerAcunMedyaDbEntities db = new StellerAcunMedyaDbEntities();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(TblAdmin admin)
        {
            var values = db.TblAdmin.FirstOrDefault(x => x.UserName == admin.UserName && x.Password == admin.Password);
			if (values == null)
			{
                ModelState.AddModelError("", "Kullanıcı adı veya şifre hatalı");
                return View();
			}
			else
			{
                FormsAuthentication.SetAuthCookie(values.UserName, false);
                Session["username"] = values.UserName;
                return RedirectToAction("index", "About");
			}
        }
    }
}