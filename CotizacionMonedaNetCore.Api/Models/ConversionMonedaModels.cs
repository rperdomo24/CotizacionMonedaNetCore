using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CotizacionMonedaNetCore.Api.Models
{
    /// <summary>
    /// Modelo retornado de el endpoint que cotiza la moneda
    /// </summary>
    public class ConversionMonedaModels
    {
        public Result result { get; set; }
        public string status { get; set; }
    }
    public class Result
    {
        public string updated { get; set; }
        public string source { get; set; }
        public string target { get; set; }
        public double value { get; set; }
        public string quantity { get; set; }
        public double amount { get; set; }

    }
}
