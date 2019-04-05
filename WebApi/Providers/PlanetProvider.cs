using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc; //para el actionResult
using System.Net.Http;
using Newtonsoft.Json;


using WebApi.Models;

namespace WebApi.Utilites
{
    public class PlanetProvider
    {

        public async Task<ActionResult<List<Planet>>> GetPlanetsAsync()
        {
            HttpClient hc = new HttpClient();
            string url = "https://swapi.co/api/planets/";
            HttpResponseMessage response = await hc.GetAsync(url);
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception("Something failed while getting the planets");
                }
            
                string responseBody = await response.Content.ReadAsStringAsync(); 
                GetPlanets input = JsonConvert.DeserializeObject<GetPlanets>(responseBody);
                return input.results;
            throw new NotImplementedException();
        }
    }

}