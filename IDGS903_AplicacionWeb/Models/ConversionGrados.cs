using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS903_AplicacionWeb.Models
{
    public class ConversionGrados
    {

        public double Grado { get; set; }
        public string Res { get; set; }
        public string opcion { get; set; }

        public void ConvertirAFahrenheit()
        {
            this.Res = ((this.Grado * 9) / 5) + 32 + "°F";
        }

        public void ConvertirACelcius()
        {
            this.Res = ((this.Grado - 32) * 5 )/ 9 + "°C";
        }




    }
}