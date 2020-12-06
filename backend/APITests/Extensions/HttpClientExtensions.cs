using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace APITests.Extensions
{
    public static class HttpClientExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="client"></param>
        /// <param name="url"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public static async Task<HttpStatusCode> PostAndReturnStatusCodeAsync<T>(this HttpClient client, string url, T request)
        {
            // TODO: check is not null for url and request

            var json = string.Empty;

            if(request != null)
            {
                json = JsonConvert.SerializeObject(request);
            }

            Debug.Write(json);

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            string completeUrl = client.BaseAddress.ToString() + url;

            HttpResponseMessage responseMessage = await client.PostAsync(url, content);

            return responseMessage.StatusCode;

        }
    }
}
