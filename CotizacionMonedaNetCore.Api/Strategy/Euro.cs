using CotizacionMonedaNetCore.Api.Extensions.ApiRequest;
using CotizacionMonedaNetCore.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CotizacionMonedaNetCore.Api.Strategy
{
    public class Euro : ICambioMoneda
    {
        /// <summary>
        /// Metodo encargado de cotizar moneda al endpoint
        /// </summary>
        /// <param name="url">url del endpoint</param>
        /// <param name="key"><llave de acceso/param>
        /// <returns> retorna la cotizacion de la moneda comparada al euro</returns>
        public MonedaModels Cotizar(string url, string key)
        {
            var result = HttpClientRequets.Request<ConversionMonedaModels>(
                $"{url}EUR/ARS/json?quantity=1&key={key}",
                HttpMethodEnum.Get);
            return new MonedaModels(result);
        }
    }
}
