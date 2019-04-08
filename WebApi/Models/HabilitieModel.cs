using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public class Habilitie 
    {
        public string Name { get; set; }
        public EnumHabilidades toUpgrade { get; set; }
        public int Damage { get; set; }
        public int Defense{ get; set; }
    }
}