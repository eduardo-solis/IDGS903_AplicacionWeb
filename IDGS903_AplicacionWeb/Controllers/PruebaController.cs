using IDGS903_AplicacionWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_AplicacionWeb.Controllers
{
    public class PruebaController : Controller
    {
        // GET: Prueba
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Opera()
        {
            OperasBas op = new OperasBas();

            return View(op);
        }

        [HttpPost]
        public ActionResult Opera(OperasBas op, string r1)
        {
            
            if(r1.Equals("Sumar"))
            {
                op.Suma();
            }
            if (r1.Equals("Restar"))
            {
                op.Resta();
            }

            return View(op);
        }


        public ActionResult Grados()
        {
            ConversionGrados cg = new ConversionGrados();
            return View(cg);
        }

        [HttpPost]
        public ActionResult Grados(ConversionGrados cg)
        {
            if (cg.opcion.Equals("C"))
            {
                cg.ConvertirACelcius();
            }

            if (cg.opcion.Equals("F"))
            {
                cg.ConvertirAFahrenheit();
            }


            return View(cg);
        }


        // GET: Prueba/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Prueba/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Prueba/Create
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

        // GET: Prueba/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Prueba/Edit/5
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

        // GET: Prueba/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Prueba/Delete/5
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
