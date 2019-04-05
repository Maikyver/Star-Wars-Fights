using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class CharacterController : Controller
    {

        //public async Task<ActionResult<List<CheckedDailyForecast>>>

        [HttpGet("[action]")]
        public int Sports()
        {
            return 1;
        }


        [HttpGet("[action]/{sportName}/{neededDays}")]
        public ActionResult<int> DailyForecasts(string sportName, int neededDays)
        {
            return 1;
        }
    }
}
