using IDGS903_AplicacionWeb.Models;
using IDGS903_AplicacionWeb.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_AplicacionWeb.Controllers
{
    public class ArchivoController : Controller
    {
        // GET: Archivo
        public ActionResult Registra()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registra(Alumnos alum)
        {
            var ope = new GuardarService();
            ope.GuardarArchivo(alum);

            return View();
        }

        public ActionResult LeerDatos()
        {
            var arch = new LeerDatosService();
            ViewBag.tem = arch.LeerArchivo();
            return View();
        }

    }
}