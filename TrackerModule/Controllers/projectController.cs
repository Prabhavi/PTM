using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrackerModule.Context;

namespace TrackerModule.Controllers
{
    public class projectController : Controller
    {
        projectContext db = new projectContext()
;        // GET: project
        public ActionResult Index()
        {
            return View(db.projects.ToList());
        }

        // GET: project/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: project/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: project/Create
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

        // GET: project/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: project/Edit/5
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

        // GET: project/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: project/Delete/5
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
