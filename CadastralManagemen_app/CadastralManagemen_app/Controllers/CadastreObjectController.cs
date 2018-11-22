using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadastralManagemen_app.Controllers
{
    public class CadastreObjectController : Controller
    {
        // GET: CadastreObject
        public ActionResult Index()
        {
            return View();
        }

        // GET: CadastreObject/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CadastreObject/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CadastreObject/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CadastreObject/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CadastreObject/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CadastreObject/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CadastreObject/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
