using IDGS903_AplicacionWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IDGS903_AplicacionWeb.Services;

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

        public ActionResult MuestraAlumnos()
        {
            var AlumnoService = new AlumnoService();
            var model = AlumnoService.ObtenerAlumno();
            return View(model);
        }
    }
}
