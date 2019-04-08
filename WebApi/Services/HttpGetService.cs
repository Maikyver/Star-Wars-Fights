using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc; //para el actionResult
using System.Net.Http;
using Newtonsoft.Json;

    public class HttpGetService
    {
        

        public async Task<T> GetTAsync<T>(string url)
        {
            HttpClient hc = new HttpClient();
                HttpResponseMessage response = await hc.GetAsync(url);
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception("Something failed while getting the planets");
                }
            
                string responseBody = await response.Content.ReadAsStringAsync(); 
                T input = JsonConvert.DeserializeObject<T>(responseBody);
                return input;
        }
    }
