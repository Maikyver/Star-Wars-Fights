using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HabilitiesController : Controller
    {
        public AbilitiesService habService = new AbilitiesService();

        [HttpGet()]
        public ActionResult<List<Weapon>> Get()
        { 
            return(Ok(habService.abilities));
        }
    }
}