﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace TestWebApplication.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //kommentar
            return View();
        }
    }
}
