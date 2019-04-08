using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc; //para el actionResult

namespace WebApi.Models
{
    public class Species
    {
        public string name { get; set; }
        public string average_height { get; set; }
        public string average_lifespan { get; set; }

        public string url;
    }
}