using System;
using System.Collections.Generic;


namespace WebApi.Models
{
    public class Planet
{
    public string name { get; set; }
    public string climate { get; set; }
    public string terrain { get; set; }
    public List<object> residents { get; set; } //devuelve una lista de URLs para hacer get de los distintos Personajes
}

}