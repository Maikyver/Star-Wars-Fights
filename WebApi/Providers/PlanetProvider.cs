using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc; //para el actionResult



using WebApi.Models;

namespace WebApi.Utilites
{
    public class PlanetProvider
    {
        HttpGetService httpGetService= new HttpGetService();
        public async Task<List<Planet>> GetPlanetsAsync()
        {
            string url = "https://swapi.co/api/planets/";

            GetPlanets planetData =  await  httpGetService.GetTAsync<GetPlanets>(url);
            return planetData.results;
        }
    }

}