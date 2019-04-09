using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

using WebApi.Utilites;
namespace WebApi.Controllers
{
    public class PlanetController : Controller
    {

        public PlanetController(
            IPlanetProvider _planetProvider
        )
        {
            planetProvider = _planetProvider;
        }
        public IPlanetProvider planetProvider;

        [HttpGet("[action]")]
        public async Task<ActionResult<List<Planet>>> Planets()
        {
            return await planetProvider.GetPlanetsAsync();
        }
    }
}