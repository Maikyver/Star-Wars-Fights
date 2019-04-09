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
            ICharacterProvider _characterProvider
        )
        {
            characterProvider= _characterProvider;
        }
        public ICharacterProvider characterProvider;
        //public async Task<ActionResult<List<CheckedDailyForecast>>>


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
        [HttpGet("[action]/{idCharacter}")]    //NO OLVIDAR QUE ESTO TIENE QUE TENER EL MISMO NOMBRE QUE EL PARAMETRO DEL METODO CHARACTERS(INT AMOUNTCHARACTERS)
        public async Task<ActionResult<Character>> Character(int idCharacter)
        {
            return await characterProvider.GetCharacterAsync(idCharacter);
        }
    }
}
