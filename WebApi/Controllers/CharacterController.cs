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
        public CharacterController(
            IPlanetProvider _planetProvider,
            ICharacterProvider _characterProvider
        )
        {
            planetProvider = _planetProvider;
            characterProvider= _characterProvider;
        }
        public IPlanetProvider planetProvider;
        public ICharacterProvider characterProvider;
        //public async Task<ActionResult<List<CheckedDailyForecast>>>

        [HttpGet("[action]")]
        public async Task<ActionResult<List<Planet>>> Planets()
        {
            return await planetProvider.GetPlanetsAsync();
        }

        //http://localhost:5000/api/Character/Characters/5 es por el momento el llamado a la funcion. falta agregar a futuro un parametro para filtrado
        [HttpGet("[action]/{amountCharacters}")]    //NO OLVIDAR QUE ESTO TIENE QUE TENER EL MISMO NOMBRE QUE EL PARAMETRO DEL METODO CHARACTERS(INT AMOUNTCHARACTERS)
        public async Task<ActionResult<List<Character>>> Characters(int amountCharacters)
        {
            if (amountCharacters <=0 )
            {
                throw new ArgumentOutOfRangeException("the amount of characters requested must be a positive int");
            }
            return await characterProvider.GetCharactersAsync(amountCharacters);
        }
    }
}
