using System.Collections.Generic;
using System;
using System.Threading.Tasks;


namespace WebApi.Models
{
    public interface ICharacterProvider
    {
        Task<List<Character>> GetCharactersAsync(int amountCharacters);
        Task<Character> GetCharacterAsync(int idCharacter);
    }

    public interface IPlanetProvider
    {
        Task<List<Planet>> GetPlanetsAsync();
    }

    public interface ISpeciesProvider
    {
        Task<Species> GetSpeciesAsync(string speciesUrl);
    }

    public interface IAbilitiesService //no tiene metodos. Se inyecta igual solo para usar sus atributos?
    {
    }

    public interface IHttpGetService
    {
        Task<T> GetTAsync<T>(string url);
    }
    public interface IWeaponService//en la misma que HabilitiesService
    {      
    }
}