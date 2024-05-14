using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StellerAcunMedyaAkademiPortfolio.Controllers
{
    [AllowAnonymous]
    public class UILayoutController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }
    }
}