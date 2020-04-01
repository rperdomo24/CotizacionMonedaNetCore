using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CotizacionMonedaNetCore.Api.Strategy;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace CotizacionMonedaNetCore.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CotizacionController : ControllerBase
    {

        private readonly IConfiguration configuration;
        private Monedas monedas;
        private string uri;
        private string key;
        public CotizacionController(IConfiguration configuration)
        {
            this.configuration = configuration;
            uri = configuration.GetSection("EndPointConversiones").Get<string>();
            key = configuration.GetSection("EndpointKeyConversiones").Get<string>();
        }

        /// <summary>
        /// Accion que retorna la cotizacion del argentina con respecto a la moneda dolar
        /// </summary>
        /// <returns></returns>
        [HttpGet("[action]")]
        public IActionResult Dolar()
        {
            try
            {
                monedas = new Monedas(new Dolar());
                return Ok(monedas.Cotizar(uri, key));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        /// <summary>
        /// Accion que retorna la cotizacion del argentina con respecto a la moneda euro
        /// </summary>
        /// <returns></returns>
        [HttpGet("[action]")]
        public IActionResult Euro()
        {
            try
            {
                monedas = new Monedas(new Euro());
                return Ok(monedas.Cotizar(uri, key));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        /// <summary>
        /// Accion que retorna la cotizacion del argentina con respecto a la moneda euro
        /// </summary>
        /// <returns></returns>
        [HttpGet("[action]")]
        public IActionResult Real()
        {
            try
            {
                monedas = new Monedas(new Real());
                return Ok(monedas.Cotizar(uri, key));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

    }
}