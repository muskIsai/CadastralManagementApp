using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CadastralManagemen_app.Models;
using System.Data.Entity;

namespace CadastralManagemen_app.Controllers
{
    public class ClientController : Controller
    {
        private CadastralManagBD1Entities db = new CadastralManagBD1Entities();

        // GET: Client
        public ActionResult Index()
        {
            var client = db.Client.Include(x => x.Users).ToList();
            return View(client);         
        }
    }
}