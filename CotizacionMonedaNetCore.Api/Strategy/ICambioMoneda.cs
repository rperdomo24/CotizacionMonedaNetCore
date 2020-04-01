using CotizacionMonedaNetCore.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CotizacionMonedaNetCore.Api.Strategy
{
    public interface ICambioMoneda
    {
        MonedaModels Cotizar(string url, string key);
    }
}

