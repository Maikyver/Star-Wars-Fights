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

    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : Controller
    {
        public PlanetProvider planetProvider = new PlanetProvider();
        //public async Task<ActionResult<List<CheckedDailyForecast>>>

        [HttpGet("[action]")]
        public async Task<ActionResult<List<Planet>>> Planets()
        {
            return await planetProvider.GetPlanetsAsync();
        }
//comentando el controller

        [HttpGet("[action]/{sportName}/{neededDays}")]
        public ActionResult<int> DailyForecasts(string sportName, int neededDays)
        {
            return 1;
        }
    }
}
