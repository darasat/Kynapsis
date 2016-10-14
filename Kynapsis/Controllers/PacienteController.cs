using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Kynapsis.Models;
using System.IO;
namespace Kynapsis.Controllers
{
    public class PacienteController : Controller
    {
        // GET: /Paciente/

        private KinapsisDBContext db = new KinapsisDBContext();
        public ActionResult Index()
        {
            return View();
        }

    }
}