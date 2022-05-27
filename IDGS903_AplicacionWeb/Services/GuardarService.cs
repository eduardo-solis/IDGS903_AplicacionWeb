using IDGS903_AplicacionWeb.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS903_AplicacionWeb.Services
{
    public class GuardarService
    {
        public void GuardarArchivo(Alumnos alum)
        {
            // Capturando los datos
            var matricula = alum.Matricula;
            var nombre = alum.Nombre;
            var apellidos = alum.Apellidos;
            var edad = alum.Edad;
            var correo = alum.Correo;

            var datos = matricula + "," + nombre + "," + apellidos + "," + edad + "," + correo + Environment.NewLine;

            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");

            File.AppendAllText(@archivo, datos);

        }
    }
}