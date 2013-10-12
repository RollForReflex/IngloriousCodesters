using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;
using System.Web.Mvc;

namespace ViewBoost.Controllers
{
    public class ProviderController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
