using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace CotizacionMonedaNetCore.Api.Extensions.ApiRequest
{
    public class HttpClientRequets
    {
        /// <summary>
        /// Envía una petición a la url especificada con las opciones
        /// de configuración requerida
        /// </summary>
        /// <typeparam name="T">Tipo de dato a esperado</typeparam>
        /// <param name="Url">Url destino</param>
        /// <param name="Method">Tipo de método de la petición</param>
        /// <param name="Data">Objeto a enviar en la petición</param>
        /// <param name="TimeOut">Tiempo de espera en minutos</param>
        /// <returns></returns>
        public static T Request<T>(string Url, HttpMethodEnum Method, object Data = null, string Token = null, int TimeOut = 10)
        {
            using (System.Net.Http.HttpClient client = new System.Net.Http.HttpClient())
            {
                try
                {
                    client.Timeout = TimeSpan.FromMinutes(TimeOut);
                    client.DefaultRequestHeaders.Accept.Add(
                        new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Accept.Add(
                         new MediaTypeWithQualityHeaderValue("text/plain"));
                    if (!string.IsNullOrEmpty(Token))
                    {
                        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token);
                    }
                    HttpResponseMessage response = null;

                    switch (Method)
                    {
                        case HttpMethodEnum.Get:
                            response = client.GetAsync(Url).Result;
                            break;
                        case HttpMethodEnum.PostJson:
                            response = client.PostAsJsonAsync(Url, Data).Result;
                            break;
                        case HttpMethodEnum.PutJson:
                            response = client.PutAsJsonAsync(Url, Data).Result;
                            break;
                        case HttpMethodEnum.Delete:
                            response = client.DeleteAsync(Url).Result;
                            break;
                        default:
                            break;
                    }

                    if (response.IsSuccessStatusCode)
                    {
                        T result = response.Content.ReadAsAsync<T>().Result;
                        return result;
                    }
                    else
                    {
                        return default(T);
                    }
                }
                catch (Exception ex)
                {
                    // Excepciones
                    throw ex;
                }
            }
        }
    }
}
