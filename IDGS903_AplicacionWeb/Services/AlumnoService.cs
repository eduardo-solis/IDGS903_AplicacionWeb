using IDGS903_AplicacionWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS903_AplicacionWeb.Services
{
    public class AlumnoService
    {
        public List<Alumnos> ObtenerAlumno()
        {
            var alumno1 = new Alumnos()
            {
                Matricula = "1111",
                Nombre = "Eduardo",
                Apellidos = "Solis Hernandez",
                Edad = 22,
                Correo = "eduardo@gmail.com"

            };

            var alumno2 = new Alumnos()
            {
                Matricula = "1121",
                Nombre = "Abel",
                Apellidos = "Mendoza Vera",
                Edad = 19,
                Correo = "abel@gmail.com"

            };

            return new List<Alumnos> { alumno1, alumno2 };
        }

    }
}