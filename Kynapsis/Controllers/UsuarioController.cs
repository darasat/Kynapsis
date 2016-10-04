using Kynapsis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kynapsis.Controllers
{
    public class UsuarioController : Controller
    {
        private KinapsisDBContext db = new KinapsisDBContext();
        // GET: Usuario
        public ActionResult Index()
        {
            // ViewBag.Message = "Your contact page.";

            return View();
        }

        // GET: Usuario Create
        public ActionResult Create()
        {
            // ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}