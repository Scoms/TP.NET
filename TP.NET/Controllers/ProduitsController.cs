using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP.NET.Service;
using TP.NETDAL.Model;
using Utils;

namespace TP.NET.Controllers
{
    public class ProduitsController : Controller
    {
        //
        // GET: /Produits/
        private ServiceProduits _service;
        private ErrorHandler _eh;

        public ProduitsController()
        {
            this._eh = new ErrorHandler();
            this._service = new ServiceProduits(this._eh);
        }

        public ActionResult Index()
        {
            List<Produits> lProduits = this._service.findAll();
            return View(lProduits);
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
