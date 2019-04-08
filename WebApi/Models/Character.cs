using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc; //para el actionResult

namespace WebApi.Models
{
    public class Character
    {
        public string name { get; set; }
        public string gender { get; set; }
        public string homeworld { get; set; }
        public List<string> species { get; set; }
        //public string url { get; set; }
    }
}