using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VM_Tipset_2.Controllers
{
    [Authorize]
    public class BettingController : Controller
    {
        //
        // GET: /Betting/

        public ActionResult Index()
        {
            return View();
        }

    }
}
