using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc; //para el actionResult

using WebApi.Models;
namespace WebApi.Utilites
{
    public class CharacterProvider : ICharacterProvider
    {
        public CharacterProvider(
            IHttpGetService _httpGetService,
            ISpeciesProvider _speciesProvider
        )
        {
            httpGetService= _httpGetService;
            speciesProvider= _speciesProvider;
        }
        IHttpGetService httpGetService;
        ISpeciesProvider speciesProvider;
        //SpeciesProvider speciesProvider = new SpeciesProvider();
        public async Task<List<Character>> GetCharactersAsync(int amountCharacters)
        {
            string url = "https://swapi.co/api/people/";
            GetCharacters charactersData = await httpGetService.GetTAsync<GetCharacters>(url);
            List<Character> result = charactersData.results;

            //TODO
            //HACER ALGUN MANEJO DE ERROR ACA POR SI ALGUN VALOR ES NULO, SI PIDO MAS PERSONAJES DE LOS QUE SWAPI TIENE
            while (result.Count < amountCharacters)
            {
                charactersData = await httpGetService.GetTAsync<GetCharacters>(charactersData.next);
                foreach (Character item in charactersData.results)
                {
                    result.Add(item);
                }
            }

            while (result.Count != amountCharacters)
            {
                //esto nunca romperia a menos que alguien busque una lista characters de 0 personajes, cosa que el controller va a chequear que no suceda.
                result.RemoveAt(result.Count - 1);
            }
            await this.SetSpeciesToCharactersAsync(result);


            return result;
        }

        private async Task SetSpeciesToCharactersAsync(List<Character> characters)
        {
            try
            {
                foreach (Character character in characters)
                {
                    character.specie = await this.speciesProvider.GetSpeciesAsync(character.species[0]);
                }
            }
            catch(Exception  e )
            {
                throw new Exception($"en SetSpeciesToCharacterAsync------------{e.Message}");
            }

        }

    }
}