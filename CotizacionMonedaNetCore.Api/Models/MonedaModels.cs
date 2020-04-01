using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CotizacionMonedaNetCore.Api.Models
{
    public class MonedaModels
    {
        public MonedaModels()
        {

        }
        /// <summary>
        /// contructor encargado de convertir de conversionesmoneda a monedamodels
        /// </summary>
        /// <param name="conversion"> Respuesta de Api cotizacion</param>
        public MonedaModels(ConversionMonedaModels conversion)
        {
            if (conversion == null)
                throw new ArgumentNullException(nameof(conversion), "Se espera que exista una conversión para devolver el valor.");

            Moneda = conversion.result.source;
            Precio = conversion.result.value;
        }

        public string Moneda { get; set; }
        public double Precio { get; set; }

    }
}
