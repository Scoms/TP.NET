using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TP.NET.Controllers
{
    public class ProduitsController : Controller
    {
        //
        // GET: /Produits/
        public

        public ActionResult Index()
        {

            return View();
        }

        //
        // GET: /Produits/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Produits/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Produits/Create

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

        //
        // GET: /Produits/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Produits/Edit/5

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

        //
        // GET: /Produits/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Produits/Delete/5

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
