﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kynapsis.Controllers
{
    public class HorarioController : Controller
    {
        // GET: Horario
        public ActionResult Index()
        {
            return View();
        }

        // Create: Horario
        public ActionResult Create()
        {
            return View();
        }

        // Create: Actual
        public ActionResult Actual()
        {
            return View();
        }
    }
}