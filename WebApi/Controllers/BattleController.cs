using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Utilites;
namespace WebApi.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class BattleController : Controller {
        public BattleHanddler battleHanddler = new BattleHanddler ();
        public BattleController () { }

        [HttpGet ("[action]")]
        public  BattleAnswer StartBattle () {
            String data = " ";

            return battleHanddler.Battle (data);
        }
    }
}