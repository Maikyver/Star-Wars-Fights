using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;


using WebApi.Models;
namespace WebApi.Utilites
{
    public class SpeciesProvider
    {
        List<Species> cache = new List<Species>();
        HttpGetService httpGetService = new HttpGetService();
        public async Task<Species> GetSpeciesAsync(string speciesUrl)
        {
            Species speciesData= this.FindByUrlOrReturnNull(speciesUrl);
            if(speciesData == null)
            {
            speciesData = await httpGetService.GetTAsync<Species>(speciesUrl);
            cache.Add(speciesData);           
            }
 
            return speciesData;
        }

        private Species FindByUrlOrReturnNull(string url)
        {
            return cache.Find(aSpecies => aSpecies.url == url);
        }

    }
}