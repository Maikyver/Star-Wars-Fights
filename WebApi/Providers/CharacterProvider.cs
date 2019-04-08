using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc; //para el actionResult

using WebApi.Models;
namespace WebApi.Utilites
{
    public class CharacterProvider
    {
        HttpGetService httpGetService = new HttpGetService();
        public async Task<List<Character>> GetCharactersAsync()
        {
            string url = "https://swapi.co/api/people/";
            GetCharacters charactersData = await httpGetService.GetTAsync<GetCharacters>(url);

            return charactersData.results;
        }


    }
}