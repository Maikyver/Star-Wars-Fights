//Para modelos que no son del dominio. Este es solo para poder hacer el get de Planets.
using System.Collections.Generic;

namespace WebApi.Models
{

public class GetPlanets
{
    public int count { get; set; }
    public string next { get; set; }
    public object previous { get; set; }
    public List<Planet> results { get; set; }
}

}