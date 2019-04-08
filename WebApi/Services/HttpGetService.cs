using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc; //para el actionResult
using System.Net.Http;
using Newtonsoft.Json;

using WebApi.Utilites;

namespace WebApi.Models
{
    public class HttpGetService : IHttpGetService
    {


        public async Task<T> GetTAsync<T>(string url)
        {
            HttpClient hc = new HttpClient();
            HttpResponseMessage response = await hc.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Something failed accesing Swapi------------{response.ReasonPhrase}");
            }

            string responseBody = await response.Content.ReadAsStringAsync();
            T input = JsonConvert.DeserializeObject<T>(responseBody);
            return input;
        }
    }
}