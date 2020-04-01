using CotizacionMonedaNetCore.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CotizacionMonedaNetCore.Api.Strategy
{
    public class Monedas
    {
        private ICambioMoneda _cambioMoneda;
        public Monedas(ICambioMoneda cambioMoneda)
        {
            _cambioMoneda = cambioMoneda;
        }

        /// <summary>
        /// invocador de la implementacion de la interfaz correspondiente
        /// </summary>
        /// <param name="url">url del endpoint</param>
        /// <param name="key">key del enpoint</param>
        /// <returns></returns>
        public MonedaModels Cotizar(string url, string key)
        {
            return _cambioMoneda.Cotizar(url, key);
        }
    }
}
