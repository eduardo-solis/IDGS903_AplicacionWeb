using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS903_AplicacionWeb.Services
{
    public class LeerDatosService
    {
        public Array LeerArchivo()
        {
            Array userData = null;

            var dataFile = HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");

            if (File.Exists(dataFile))
            {
                userData = File.ReadAllLines(dataFile);
            }

            return userData;
        }
    }
}