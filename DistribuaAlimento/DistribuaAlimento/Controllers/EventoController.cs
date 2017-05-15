using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DistribuaAlimento.Controllers
{
    public class EventoController : Controller
    {
        // GET: Evento
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Create()
        {


            return View();
        }

    }


   
}