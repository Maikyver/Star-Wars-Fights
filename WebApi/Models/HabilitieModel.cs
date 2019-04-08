using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public class Habilitie 
    {
        public string name { get; set; }
        public EnumHabilidades ID { get; set; }
        public List<EnumArmas> toUpgrade { get; set; }
        public int Damage { get; set; }
        public int Defense{ get; set; }
        static public List<string> names = new List<string>() {"Force Crush", "Culling Blade", "Old Jedi Knight","Quick Shot", "Protective Maneuver", "Blas Smash"} ;
    }
}